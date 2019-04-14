using Microsoft.EntityFrameworkCore;

namespace braviApi.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<People> Peoples { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}