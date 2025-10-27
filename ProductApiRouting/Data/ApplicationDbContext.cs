using Microsoft.EntityFrameworkCore;
using ProductApiRouting.Models;

namespace ProductApiRouting.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop Dell", Code = "LAP", Price = 15000000 },
                new Product { Id = 2, Name = "Chuột Logitech", Code = "MOU", Price = 500000 },
                new Product { Id = 3, Name = "Bàn phím cơ", Code = "KEY", Price = 1200000 },
                new Product { Id = 123, Name = "Màn hình Samsung", Code = "MON", Price = 3500000 }
            );
        }
    }
}

