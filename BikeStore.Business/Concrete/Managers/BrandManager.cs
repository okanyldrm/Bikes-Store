using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _branddal;

        public BrandManager(IBrandDal brandDal)
        {
            _branddal = brandDal;
        }
        public void Add(Brand brand)
        {
            _branddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _branddal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _branddal.GetList();
        }

        public Brand GetById(int brandId)
        {
            return _branddal.Get(b => b.brand_id == brandId);
        }

        public void update(Brand brand)
        {
            _branddal.Update(brand);
        }
    }
}
