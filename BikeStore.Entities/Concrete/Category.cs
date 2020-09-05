﻿using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class Category :IEntity
    {

        [Key]
        public int category_id { get; set; }

        public string category_name { get; set; }

    }
}
