using BikeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Entities.Concrete
{
    public class Store : IEntity
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}
