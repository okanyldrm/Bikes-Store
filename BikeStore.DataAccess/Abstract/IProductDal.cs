using BikeStore.Core.DataAccess;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Entities.ComplexType;

namespace BikeStore.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {

        List<ProductDetail> GetProductDetails();
        List<Product> GetMaxPriceProduct();
        List<Product> GetByCategory(int categoryId);

    }
}
