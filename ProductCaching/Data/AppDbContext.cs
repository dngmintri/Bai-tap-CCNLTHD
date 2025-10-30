using Microsoft.EntityFrameworkCore;
using ProductCaching.Models;

namespace ProductCaching.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed 100 products
            var products = new List<Product>();
            var categories = new[] { "Laptop", "Điện thoại", "Tai nghe", "Màn hình", "Bàn phím", "Chuột", "Webcam", "Loa", "Router", "USB" };
            var brands = new[] { "Dell", "Apple", "Samsung", "Sony", "LG", "Asus", "Logitech", "HP", "Acer", "Lenovo" };

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"{categories[i % categories.Length]} {brands[i % brands.Length]} {i}",
                    Description = $"Sản phẩm cao cấp số {i}",
                    Price = (i * 100000) + (i % 10) * 50000
                });
            }

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}