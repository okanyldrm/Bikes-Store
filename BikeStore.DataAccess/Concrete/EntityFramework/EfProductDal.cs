using BikeStore.Core.DataAccess.EntityFramework;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BikeStore.Entities.ComplexType;
using Microsoft.EntityFrameworkCore;
using VisioForge.Shared.MediaFoundation.OPM;

namespace BikeStore.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, BikeStoreContext>, IProductDal
    {

        //Linq ile db'ye sordu gönderme
        public List<ProductDetail> GetProductDetails()
        {
            using (BikeStoreContext context = new BikeStoreContext())
            {

                var result =
                        from p in context.Products
                        join c in context.Categories on p.category_id equals c.category_id
                        join s in context.Stocks on p.product_id equals s.product_id

                        select new ProductDetail
                        {
                            ProductId = p.product_id,
                            ProductName = p.product_name,
                            CategoryName = c.category_name,
                            Quantity = s.quantity,
                            Price = p.list_price
                        };
                return result.ToList();
            }
        }


        //Metinsel isteklerde direk sql sorgu çalıştırma
        public List<Product> GetMaxPriceProduct()
        {
            using (BikeStoreContext context = new BikeStoreContext())
            {
                var result = context.Products.FromSqlRaw(
                        "Select * from products where products.list_price = ( Select MAX(products.list_price) from products  ) ")
                    .ToList();
                return result;
            }
        }

        public List<Product> GetByCategory(int categoryId)
        {
            using (BikeStoreContext context = new BikeStoreContext())
            {
                string query = "Select * From products where products.category_id = " + categoryId;
                var result = context.Products.FromSqlRaw(query).ToList();
                return result;
            }
        }
    }
}

