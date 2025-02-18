using EksamensOpgaveBackend.Data;
using EksamensOpgaveBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensOpgaveBackend.Controllers
{
    public class AddProductController : Controller
    {
        
        private readonly ConnectDbContext _DbContext;


        public AddProductController(ConnectDbContext dbContext)
        {
            _DbContext = dbContext;
        }



        public IActionResult Index()
        {
            return View();
        }



        public IActionResult CreateProduct(ProductModel productModel)
        {

            var Product = new ProductModel
            {
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price,
                ImageUrl = productModel.ImageUrl,
                YearOfProduction = productModel.YearOfProduction,
            };

            _DbContext.productModels.Add(Product);
            _DbContext.SaveChanges();


            return View();
        }
    }
}
