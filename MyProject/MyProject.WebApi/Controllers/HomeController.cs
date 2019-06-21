using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.WebApi.Models;

namespace MyProject.WebApi.Controllers
{
    public class HomeController : BaseController
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            this.SetTitle("Anasayfa");

            //Uygulama ilk açıldığında db yok ise bir kere çalıştır.
            //this._productService.AddDefaultProducts();

            var model = new ProductLisViewModel
            {
                Products = this._productService.GetAll()
            };

            return View(model);
        }
    }
}