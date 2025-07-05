using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RetailStoreDbContextLab.Data;
using RetailStoreDbContextLab.Models;

namespace RetailStoreDbContextLab
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            // Create database and tables if not exists
            context.Database.EnsureCreated();

            // Insert sample data if none exists
            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var grocery = new Category { Name = "Groceries" };

                context.Categories.AddRange(electronics, grocery);
                context.SaveChanges();

                context.Products.AddRange(
                    new Product { Name = "Laptop", Price = 50000, CategoryId = electronics.Id },
                    new Product { Name = "Headphones", Price = 1500, CategoryId = electronics.Id },
                    new Product { Name = "Wheat Flour", Price = 400, CategoryId = grocery.Id }
                );
                context.SaveChanges();

                Console.WriteLine("✅ Sample data inserted.");
            }

            // Display products
            var products = context.Products.Include(p => p.Category).ToList();

            Console.WriteLine("\n📦 Product List:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price} - Category: {product.Category.Name}");
            }
        }
    }
}
