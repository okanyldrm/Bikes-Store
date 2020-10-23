using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    
    public class Product : IEntity
    {
        [Key]
        public int product_id { get; set; }
        public int brand_id { get; set; }
        public int category_id { get; set; }
        public string product_name { get; set; }
        public short model_year { get; set; }
        public decimal list_price { get; set; }
        public int? product_photo_id { get; set; }
    }
}
