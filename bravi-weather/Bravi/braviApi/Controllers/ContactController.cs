using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using braviApi.Models;

namespace braviApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {   
       
        private readonly Context _context;

            public ContactController(Context context)
            {
                _context = context;

                // if (_context.Contacts.Count() == 0)
                // {
                //     _context.Contacts.Add(new Contact { Email = "teste@gmail.com" });
                //     _context.SaveChanges();
                // }
            }

            // GET: api/contact
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
            {
                return await _context.Contacts.ToListAsync();
            }

               // GET: api/contact/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Contact>> GetContacts(long id)
            {
                var contact = await _context.Contacts.FindAsync(id);

                if (contact == null)
                {
                    return NotFound();
                }

                return contact;
            }

            // POST: api/contact
            [HttpPost]
            public async Task<ActionResult<Contact>> PostContact(Contact contact)
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetContacts), new { id = contact.Id }, contact);
            }

            // PUT: api/contact/2
            [HttpPut("{id}")]
            public async Task<IActionResult> PutContact(long id, Contact contact)
            {
                if (id != contact.Id)
                {
                    return BadRequest();
                }

                _context.Entry(contact).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            // DELETE: api/contact/2
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteContact(long id)
            {
                var contact = await _context.Contacts.FindAsync(id);

                if (contact == null)
                {
                    return NotFound();
                }

                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();

                return NoContent();
            }

    }
}
