using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Core.Entities;

namespace BikeStore.Entities.ComplexType
{
    public class ProductDetail 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
        public string Photo { get; set; }

    }
}
