using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Entities.ComplexType;

namespace BikeStore.Business.Abstract
{
   public  interface IProductService
    {


        List<Product> GetAll();
        Product GetById(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<ProductDetail> GetProductDetails();
        List<Product> MaxPriceProduct();


    }
}
