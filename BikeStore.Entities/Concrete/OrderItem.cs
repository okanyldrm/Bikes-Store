using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class OrderItem : IEntity
    {

        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Discount { get; set; }

    }
}
