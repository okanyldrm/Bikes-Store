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

        //<summary>
        //Product getall fonksiyonu 
        //</summary>
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

        [HttpPost("AddProduct")]
        public void AddProduct([FromBody]Product product)
        {
            _productService.Add(product);
            
        }

        [HttpDelete("DeleteProduct/{product}")]
        public IActionResult DeleteProduct([FromBody]Product product)
        {
            _productService.Delete(product);
            string message = product.product_id + "-Deleted";
            return Json(message);

        }


        [HttpPut("UpdateProduct/{product}")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productService.Update(product);
            string message = product.product_id+ "-Updated";
            return Json(message);
        }





    }
}
