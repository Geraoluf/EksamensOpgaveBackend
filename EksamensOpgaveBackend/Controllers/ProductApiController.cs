using EksamensOpgaveBackend.Data;
using EksamensOpgaveBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

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
            var products = await _context.productModels.ToListAsync();
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Gør JSON-output mere læsbart
            };

            return new JsonResult(products, options);
            
        }



        // GET: api/productapi/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductModel>> GetProduct(int id)
        {
            var product = await _context.productModels.FindAsync(id); // Finder kun det ene produkt

            if (product == null)
            {
                return NotFound(); // Returnerer 404, hvis produktet ikke findes
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Gør JSON-output mere læsbart
            };

            return new JsonResult(product, options);
        }
    }
}
