using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class StoreManager : IStoreService
    {

        private IStoreDal _storeDal;

        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public void Add(Store store)
        {
            _storeDal.Add(store);
        }

        public void Delete(Store store)
        {
            _storeDal.Delete(store);
        }

        public List<Store> GetAll()
        {
            return _storeDal.GetList();
        }

        public Store GetById(int storeId)
        {
            return _storeDal.Get(s => s.StoreId == storeId);
        }

        public void Update(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
