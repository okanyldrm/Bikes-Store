using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Entities.ComplexType;

namespace BikeStore.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {

        private IProductDal _productDal;


        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<ProductDetail> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public ProductDetail GetProductDetailsById(int productId)
        {
            return _productDal.GetProductDetailsById(productId);
        }

        public List<Product> MaxPriceProduct()
        {
            return _productDal.GetMaxPriceProduct();
        }

        public List<Product> GetByCategories(int categoryId)
        {
            return _productDal.GetByCategory(categoryId);
        }


        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.product_id == productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }


        
    }
}
