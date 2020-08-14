using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class OrderManager : IOrderService
    {

        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }


        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetList();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.Get(o => o.OrderId == orderId);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
