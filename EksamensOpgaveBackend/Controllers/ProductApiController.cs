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
    public class ProductApiController : Controller
    {
        private readonly ConnectDbContext _dbcontext;

        public ProductApiController(ConnectDbContext context)
        {
            _dbcontext = context;
        }



        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            var products = await _dbcontext.productModels.ToListAsync();
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Læse venligt
            };


            return new JsonResult(products, options);
            
        }


      
            [HttpGet("{id}")]
            public async Task<IActionResult> GetProductView(int id)
            {
                var product = await _dbcontext.productModels.FindAsync(id); 

                if (product == null)
                {
                    return NotFound(); //404
                }

                return Ok (product); 
            }

        }
    }
