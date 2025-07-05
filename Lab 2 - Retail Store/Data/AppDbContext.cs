using Microsoft.EntityFrameworkCore;
using RetailStoreDbContextLab.Models;

namespace RetailStoreDbContextLab.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RetailStoreDB;Trusted_Connection=True;");
        }
    }
}
