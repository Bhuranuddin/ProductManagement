using Microsoft.EntityFrameworkCore;
using ProductManagementProject.Models;

namespace ProductManagementProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ProductNumberSequence> ProductNumberSequences { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductNumberSequence>().HasData(
                new ProductNumberSequence { Id = 1, LastNumber = 99999 } // Starts from 100000
                );
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.ProductNumber)
                .IsUnique();
        }
    }
}