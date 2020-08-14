using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class CustomerManager : ICustomerService
    {


        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {

            _customerDal = customerDal;

        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList();
        }

        public Customer GetById(int customerId)
        {
            return _customerDal.Get(c => c.CustomerId == customerId);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
