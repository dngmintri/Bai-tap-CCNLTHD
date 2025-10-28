using Microsoft.AspNetCore.Mvc;
using ProductDetails.Models;

namespace ProductDetails.Controllers;

public class ProductController : Controller
{
    private static readonly List<Product> _products = [
        new() { Id = 1, Name = "Bàn phím cơ Keychron K6", Description = "Bàn phím cơ nhỏ gọn, switch Gateron, kết nối Bluetooth.", Price = 25000000 },
        new() { Id = 2, Name = "Màn hình Samsung 24 inch", Description = "Màn hình Full HD, tần số quét 75Hz, viền mỏng.", Price = 700000 },
        new() { Id = 3, Name = "Tai nghe Sony WH-1000XM5", Description = null, Price = 1200000 }
    ];
    public IActionResult Details(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        ViewData["ProductId"] = id;
        return View(product);
    }
    public IActionResult Index()
    {
        return View();
    }
}
