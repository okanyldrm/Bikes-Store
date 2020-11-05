using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Entities.ComplexType;
using BikeStore.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BikeStore.WebUI.Controllers
{


    //Identity bu sınıf giriş yapılmadan kullanılamaz
    //[Authorize]
   
    public class ProductController : Controller
    {


        private IProductService _productService;
        private IBrandService _brandService;
        private readonly IHostingEnvironment _environment;

        public ProductController(IProductService productService, IHostingEnvironment environment, IBrandService brandService)
        {
            _productService = productService;
            _environment = environment;
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult GetAllProductView()
        {
            return View();
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


        public IActionResult GetByCategoriesMounth(int categoryId=6)
        {
            List<Product> productsOfCategory = _productService.GetByCategories(categoryId);

            var model = new ProductListViewModel()
            {
                Products = productsOfCategory
            };
            return Json(model);
        }


        public IActionResult GetByCategoriesRoad(int categoryId = 7)
        {
            List<Product> productsOfCategory = _productService.GetByCategories(categoryId);

            var model = new ProductListViewModel()
            {
                Products = productsOfCategory
            };
            return Json(model);
        }

        public IActionResult GetByCategoriesKid(int categoryId = 1)
        {
            List<Product> productsOfCategory = _productService.GetByCategories(categoryId);

            var model = new ProductListViewModel()
            {
                Products = productsOfCategory
            };
            return Json(model);
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


        public IActionResult Detail(int productId)
        {
            //Product model = _productService.GetById(productId);
            ProductDetail model = _productService.GetProductDetailsById(productId);
            return View(model);
        }

        //new Template istekler


        public IActionResult CategoriesView()
        {

            List<Brand> Brands = _brandService.GetAll();



            return View(Brands);
        }




    }

  
}