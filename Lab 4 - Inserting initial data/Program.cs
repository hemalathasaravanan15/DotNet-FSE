using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RetailStoreDbContextLab.Data;
using RetailStoreDbContextLab.Models;

namespace RetailStoreDbContextLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("Retrieving all products:");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
                Console.WriteLine($"{p.Name} - ₹{p.Price}");

            Console.WriteLine("\nFinding product by ID = 1:");
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"Found: {product?.Name}");

            Console.WriteLine("\nFinding expensive product (Price > 50000):");
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"Expensive: {expensive?.Name}");
        }
    }
}
