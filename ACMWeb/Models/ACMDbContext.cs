using ACM.BL;
using Microsoft.EntityFrameworkCore;

namespace ACMWeb.Models
{
    public class ACMDbContext : DbContext
    {
        public ACMDbContext(DbContextOptions<ACMDbContext> options) : base(options)
        { 
        }

        public DbSet<Product> Products { get; set; }
    }
}
