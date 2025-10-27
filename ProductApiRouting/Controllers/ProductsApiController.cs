using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApiRouting.Data;
using ProductApiRouting.Models;

namespace ProductApiRouting.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ProductsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            
            if (product == null)
            {
                return NotFound(new { message = $"Không tìm thấy sản phẩm có ID = {id}" });
            }
            
            return Ok(product);
        }

        [HttpGet("code/{code:alpha:length(3)}")]
        public async Task<ActionResult<Product>> GetByCode(string code)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(p => p.Code.ToUpper() == code.ToUpper());
            
            if (product == null)
            {
                return NotFound(new { message = $"Không tìm thấy sản phẩm có mã = {code}" });
            }
            
            return Ok(product);
        }
    }
}

