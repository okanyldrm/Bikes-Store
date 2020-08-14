using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IOrderService
    {

        List<Order> GetAll();
        Order GetById(int orderId);
        void Add(Order order);
        void Delete(Order order);
        void Update(Order order);


    }
}
