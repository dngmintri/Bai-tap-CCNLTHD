using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;
using ProductCaching.Models;
using ProductCaching.Data;

namespace ProductCaching.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMemoryCache _cache;
        private readonly AppDbContext _context;

        public ProductController(IMemoryCache cache, AppDbContext context)
        {
            _cache = cache;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            const string cacheKey = "all_products";
            var startTime = DateTime.Now;
            
            // Bước 1: Thử lấy từ cache
            if (_cache.TryGetValue(cacheKey, out List<Product>? cachedProducts))
            {
                var cacheTime = (DateTime.Now - startTime).TotalMilliseconds;
                ViewBag.Message = $"Lấy từ CACHE ({cacheTime:F2} ms)";
                ViewBag.Source = "Memory Cache";
                return View(cachedProducts);
            }
            
            // Bước 2: Không có cache → Lấy từ Database
            var products = await _context.Products.ToListAsync();
            var dbTime = (DateTime.Now - startTime).TotalMilliseconds;
            
            ViewBag.Message = $"Lấy từ DATABASE ({dbTime:F2} ms)";
            ViewBag.Source = "MySQL Database";
            
            // Bước 3: Lưu vào cache, hết hạn sau 5 phút
            var cacheOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
            
            _cache.Set(cacheKey, products, cacheOptions);
            
            return View(products);
        }

        public IActionResult ClearCache()
        {
            _cache.Remove("all_products");
            TempData["Message"] = "Cache đã được xóa! Nhấn F5 để load lại từ Database.";
            return RedirectToAction("Index");
        }
    }
}