using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class StockManager : IStockService
    {

        private IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }


        public void Add(Stock stock)
        {
            _stockDal.Add(stock);
        }

        public void Delete(Stock stock)
        {
            _stockDal.Delete(stock);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetList();
        }

        public Stock GetById(int storeId)
        {
            return _stockDal.Get(s => s.store_id == storeId);
        }

        public void Update(Stock stock)
        {
            _stockDal.Update(stock);
        }
    }
}
