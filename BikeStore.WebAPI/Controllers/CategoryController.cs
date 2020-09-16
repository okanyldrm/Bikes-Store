using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BikeStore.WebAPI.Controllers
{

    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var Categories = _categoryService.GetAll();

            var model = new CategoryViewListModel()
            {
                Categories = Categories
            };

            return Json(model);

        }


        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var Category = _categoryService.GetById(id);
            return Json(Category);
        }


    }
}