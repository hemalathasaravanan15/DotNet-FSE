using RetailInventory.Data;
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var grocery = new Category { Name = "Groceries" };

                context.Categories.AddRange(electronics, grocery);

                context.Products.AddRange(
                    new Product { Name = "Smartphone", Stock = 30, Category = electronics },
                    new Product { Name = "Rice Bag", Stock = 100, Category = grocery }
                );

                context.SaveChanges();
                Console.WriteLine("Sample data inserted.");
            }

            var products = context.Products.Include(p => p.Category).ToList();

            Console.WriteLine("\nInventory List:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Category.Name} - Stock: {product.Stock}");
            }
        }
    }
}
