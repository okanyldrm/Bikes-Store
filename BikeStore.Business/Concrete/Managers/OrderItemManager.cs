using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class OrderItemManager : IOrderItemService
    {
        private IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }


        public void Add(OrderItem orderItem)
        {
            _orderItemDal.Add(orderItem);
        }

        public void Delete(OrderItem orderItem)
        {
            _orderItemDal.Delete(orderItem);
        }

        public List<OrderItem> GetAll()
        {
            return _orderItemDal.GetList();
        }

        public OrderItem GetById(int orderItemId)
        {
            return _orderItemDal.Get(o => o.OrderId == orderItemId);
        }

        public void Update(OrderItem orderItem)
        {
            _orderItemDal.Update(orderItem);
        }
    }
}
