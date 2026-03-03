using Microsoft.EntityFrameworkCore;
using PTPMQL_MVC.Models.Entities;

namespace PTPMQL_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}