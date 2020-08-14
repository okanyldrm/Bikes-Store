using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IStoreService
    {

        List<Store> GetAll();
        Store GetById(int storeId);
        void Add(Store store);
        void Delete(Store store);
        void Update(Store store);

    }
}
