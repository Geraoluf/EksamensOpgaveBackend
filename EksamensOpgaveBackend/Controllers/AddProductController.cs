using EksamensOpgaveBackend.Data;
using EksamensOpgaveBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace EksamensOpgaveBackend.Controllers
{
    public class AddProductController : Controller
    {
        
        private readonly ConnectDbContext _DbContext;
        private readonly IWebHostEnvironment _WebHostEnvironment;


        public AddProductController(ConnectDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _DbContext = dbContext;
            _WebHostEnvironment = webHostEnvironment;
        }



        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProduct(ProductModel productModel)
        {
            if (productModel.Image !=  null)
            {
                string fileName = Guid.NewGuid().ToString()+ Path.GetExtension(productModel.Image.FileName);
                string imagePath = Path.Combine(_WebHostEnvironment.WebRootPath, @"Images/Product");
                using var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                productModel.Image.CopyTo(fileStream);
                productModel.ImageUrl = $"/Images/Product/{fileName}";

            }
            else
            {
                productModel.ImageUrl = "https://placehold.co/600x400";
                
            }

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

            return View(Product);

        }



        
    }
}
