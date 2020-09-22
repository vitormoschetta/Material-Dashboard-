using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Material.Models;
using Material.Repositories;

namespace Material.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            return View(repository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            repository.Create(product);
            return RedirectToAction("Index");
        }



        public IActionResult Edit(Guid id)
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            repository.Update(product);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(Guid id)
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            return View(repository.GetById(id));
        }

        [HttpPost]
        public IActionResult DeleteConfirm(Guid id)
        {
            ProductFakeRepository repository = new ProductFakeRepository();
            repository.Delete(id);
            return RedirectToAction("Index");
        }





    }
}
