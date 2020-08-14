using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IStockService
    {

        List<Stock> GetAll();
        Stock GetById(int storeId);
        void Add(Stock stock);
        void Delete(Stock stock);
        void Update(Stock stock);


    }
}
