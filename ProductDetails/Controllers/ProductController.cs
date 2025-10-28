using Microsoft.AspNetCore.Mvc;
using ProductDetails.Models;

namespace ProductDetails.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details(int id)
        {
            // Danh sách sản phẩm mẫu
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Chuột Logitech G102",
                    Price = 399000,
                    Description = "<p>Chuột chơi game có cảm biến quang học 8000 DPI.</p>"
                },
                new Product
                {
                    Id = 2,
                    Name = "Bàn phím cơ Keychron K6",
                    Price = 1990000,
                    Description = "<p>Bàn phím cơ nhỏ gọn, switch Gateron, kết nối Bluetooth.</p>"
                },
                new Product
                {
                    Id = 3,
                    Name = "Màn hình Samsung 24 inch",
                    Price = 2890000,
                    Description = "<p>Màn hình Full HD, tần số quét 75Hz, viền mỏng.</p>"
                },
                new Product
                {
                    Id = 4,
                    Name = "Tai nghe Sony WH-1000XM5",
                    Price = 7990000,
                    Description = "<p>Tai nghe chống ồn chủ động, pin lên tới 30 giờ.</p>"
                }
            };

            // Tìm sản phẩm theo id
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return Content($"Không tìm thấy sản phẩm có ID = {id}");
            }

            return View(product);
        }
    }
}
