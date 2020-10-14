using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BikeStore.Core.Entities;

namespace BikeStore.Entities.Concrete
{
    public class ProductPhoto : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int product_id { get; set; }
        public int photo_id { get; set; }
    }
}
