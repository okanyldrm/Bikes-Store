using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BikeStore.WebAPI.Controllers
{

    [Route("api/[controller]")]
    public class ProductController : Controller
    {



        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }





        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var Products = _productService.GetAll();

            ProductViewListModel model = new ProductViewListModel()
            {
                Products = Products
            };

            return Json(model);

        }

    }
}
