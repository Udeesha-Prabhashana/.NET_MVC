using Microsoft.EntityFrameworkCore;
using NetPro.Web.Models;

namespace NetPro.Web.Data
{
    public class ApplicationDbContext : DbContext              //ApplicationDbContext inherit from DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

    }
}
