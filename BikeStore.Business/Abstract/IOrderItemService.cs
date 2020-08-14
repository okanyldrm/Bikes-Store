using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IOrderItemService
    {

        List<OrderItem> GetAll();

        OrderItem GetById(int orderItemId);

        void Add(OrderItem orderItem);
        void Delete(OrderItem orderItem);
        void Update(OrderItem orderItem);

    }
}
