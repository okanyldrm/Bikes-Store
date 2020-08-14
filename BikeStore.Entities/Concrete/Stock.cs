using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class Stock :IEntity
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
