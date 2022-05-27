using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ACM.BL;

namespace ACMWeb.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app) 
        { 
            ACMDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ACMDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product
                    {
                        ProductName = "Kayak", 
                        ProductDescription = "A boat for one person",
                        CurrentPrice = 275                        
                    }

                );

                context.SaveChanges();
            }
        }

    }
}
