using EksamensOpgaveBackend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EksamensOpgaveBackend.Controllers
{
    public class DeleteController : Controller
    {
        private readonly ConnectDbContext _dbcontext;

        public DeleteController(ConnectDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _dbcontext.productModels.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dbcontext.productModels.Remove(product);
                _dbcontext.SaveChanges();
            }
            return RedirectToAction("List", "ListOfProducts");
        }

    }
}
