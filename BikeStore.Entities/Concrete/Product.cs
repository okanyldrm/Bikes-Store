using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class Product : IEntity
    {

        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }
    }
}
