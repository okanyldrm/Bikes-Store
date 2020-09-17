using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BikeStore.WebUI.Models;

namespace BikeStore.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private ICategoryService _categoryService;
        private IProductService _productService;

        public HomeController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }


        public IActionResult Index()
        {
            var model = new IndexViewListModel()
            {
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        public IActionResult ChildrenBicycles()
        {
            return View();
        }

        public IActionResult GetChildrenBicycles(int id)
        {
            var model = new ProductListViewModel()
            {
                Products = _productService.GetByCategories(id)
            };
            return Json(model);
        }


    }
}
