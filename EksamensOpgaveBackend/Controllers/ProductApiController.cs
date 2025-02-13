using EksamensOpgaveBackend.Data;
using EksamensOpgaveBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EksamensOpgaveBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly ConnectDbContext _context;

        public ProductApiController(ConnectDbContext context)
        {
            _context = context;
        }



        // GET: api/productapi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            return await _context.productModels.ToListAsync();
        }



        // GET: api/productapi/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> GetProduct(int id)
        {
            var product = await _context.productModels.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
    }
}
