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
        public class PeopleController : ControllerBase
        {
            private readonly Context _context;

            public PeopleController(Context context)
            {
                _context = context;

                // if (_context.Peoples.Count() == 0)
                // {
                //     _context.Peoples.Add(new People { Name = "Item1" });
                //     _context.SaveChanges();
                // }
            }

            // GET: api/people
            [HttpGet]
            public async Task<ActionResult<IEnumerable<People>>> GetPeoples()
            {
                return await _context.Peoples.ToListAsync();
            }

            // GET: api/people/5
            [HttpGet("{id}")]
            public async Task<ActionResult<People>> GetPeoples(long id)
            {
                var people = await _context.Peoples.FindAsync(id);

                if (people == null)
                {
                    return NotFound();
                }

                return people;
            }

            // POST: api/people
            [HttpPost]
            public async Task<ActionResult<People>> PostPeople(People people)
            {
                _context.Peoples.Add(people);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetPeoples), new { id = people.Id }, people);
            }

            // PUT: api/people/2
            [HttpPut("{id}")]
            public async Task<IActionResult> PutPeople(long id, People people)
            {
                if (id != people.Id)
                {
                    return BadRequest();
                }

                _context.Entry(people).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            // DELETE: api/people/2
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeletePeople(long id)
            {
                var people = await _context.Peoples.FindAsync(id);

                var contact = new ContactController(_context);

                await contact.DeleteContact(id);

                if (people == null)
                {
                    return NotFound();
                }

                _context.Peoples.Remove(people);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
}