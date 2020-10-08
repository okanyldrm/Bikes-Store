using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BikeStore.Core.Entities;

namespace BikeStore.Entities.Concrete
{
    public class RegisterModel : IEntity
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }


    }
}
