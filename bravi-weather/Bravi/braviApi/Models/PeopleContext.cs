using Microsoft.EntityFrameworkCore;

namespace braviApi.Models
{
    public class PeopleContext: DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        public DbSet<People> Peoples { get; set; }
    }
}