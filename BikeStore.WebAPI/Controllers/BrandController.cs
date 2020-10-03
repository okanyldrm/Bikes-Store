using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Entities.Concrete;
using BikeStore.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeStore.WebAPI.Controllers
{
    public class BrandController : Controller
    {
        private IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var model = new BrandViewListModel
            {
                Brands = _brandService.GetAll()
            };

            return Json(model);
        }



        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {

            var model = _brandService.GetById(id);

            return Json(model);
        }


        [HttpPost("AddBrand")]
        public IActionResult AddBrand([FromBody]Brand brand)
        {

           _brandService.Add(brand);
           var message = brand.brand_id + "-Added";

            return Json(message);
        }


        [HttpDelete("DeleteBrand")]
        public IActionResult DeleteBrand([FromBody] Brand brand)
        {

            _brandService.Delete(brand);
            var message = brand.brand_id + "-Deleted";

            return Json(message);
        }


        [HttpPut("UpdateBrand")]
        public IActionResult UpdateBrand([FromBody] Brand brand)
        {

            _brandService.update(brand);
            var message = brand.brand_id + "-Updated";

            return Json(message);
        }












    }
}
