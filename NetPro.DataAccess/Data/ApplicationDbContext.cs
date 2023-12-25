using Microsoft.EntityFrameworkCore;
using NetPro.Models;


namespace NetPro.DataAccess.Data
{
    public class ApplicationDbContext : DbContext              //ApplicationDbContext inherit from DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
            //    new Category { Id = 2, Name = "Scrif", DisplayOrder = 2 },
            //    new Category { Id = 3, Name = "safe", DisplayOrder = 3 }
            //);
        }

    }
}
