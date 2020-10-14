using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BikeStore.Core.Entities;

namespace BikeStore.Entities.Concrete
{
    public class Photo : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string photo_url { get; set; }
       


    }
}
