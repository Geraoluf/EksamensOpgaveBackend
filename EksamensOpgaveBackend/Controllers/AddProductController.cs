using EksamensOpgaveBackend.Data;
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



        public IActionResult CreateProduct()
        {


            return View();
        }
    }
}
