using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Entities.ComplexType;
using BikeStore.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var Product = _productService.GetById(id);

            return Json(Product);
        }

        [HttpGet("productdetail")]
        public IActionResult GetProductDetail()
        {

            List<ProductDetail> productDetails = _productService.GetProductDetails();

            return Json(productDetails);
        }

        
        [HttpGet("ProductGetByCategoryId/{categoryId}")]
        public IActionResult ProductGetByCategoryId(int categoryId)
        {
            List<Product> products = _productService.GetByCategories(categoryId);
            return Json(products);
        }



    }
}
