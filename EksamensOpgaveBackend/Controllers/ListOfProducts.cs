﻿using EksamensOpgaveBackend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EksamensOpgaveBackend.Controllers
{
    public class ListOfProducts : Controller
    {

        private readonly ConnectDbContext _dbcontext;

        public ListOfProducts(ConnectDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public IActionResult List()
        {
            var product = _dbcontext.productModels.ToList();

            return View(product);
        }


        

    }
}
