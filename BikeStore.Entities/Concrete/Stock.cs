using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class Stock :IEntity
    {
        [Key]
        public int store_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }

    }
}
