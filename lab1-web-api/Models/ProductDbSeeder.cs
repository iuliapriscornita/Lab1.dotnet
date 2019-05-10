using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_web_api.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();
            if(context.Products.Any())
            {
                return; //DB has been seeded
            }
            context.Products.AddRange(
                new Product
                {
                    Name = "Usbcable",
                    Description = "Yellow",
                    Category = "Electronics",
                    Price = 5
                },
                new Product
                {
                    Name = "Laptop",
                    Description = "Asus",
                    Category = "Electronics",
                    Price = 5030

                }
                );
            context.SaveChanges();

        }
       
    }
}
