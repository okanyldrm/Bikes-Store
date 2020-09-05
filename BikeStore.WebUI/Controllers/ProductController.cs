using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Entities.ComplexType;
using BikeStore.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace BikeStore.WebUI.Controllers
{

   
    public class ProductController : Controller
    {


        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        public IActionResult GetAll()
        {

            List<Product> products = _productService.GetAll();
            var model = new ProductListViewModel()
            {
                Products = products
            };
            return Json(model);
        }



        public IActionResult GetAllProductView()
        {
            return View();
        }


        public IActionResult GetProductDetail()
        {
            List<ProductDetail> productDetails = _productService.GetProductDetails();
            var model = new ProductDetailListViewModel()
            {
                ProductDetails = productDetails
            };
            return Json(model);
        }


        public IActionResult MaxProductGet()
        {

            var result = _productService.MaxPriceProduct();

            return Json(result);
        }

        public IActionResult GetById(int id=2)
        {
            var result = _productService.GetById(id);

            return Json(result);
        }





    }

  
}