using Microsoft.EntityFrameworkCore;
using PersonMVC.Models;

namespace PersonMVC.Data
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
