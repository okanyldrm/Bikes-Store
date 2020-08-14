using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Concrete.Managers
{
    public class StaffManager : IStaffService
    {

        private IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public void Add(Staff staff)
        {
            _staffDal.Add(staff);
        }

        public void Delete(Staff staff)
        {
            _staffDal.Delete(staff);
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetList();
        }

        public Staff GetById(int staffId)
        {
            return _staffDal.Get(s => s.StaffId == staffId);
        }

        public void Update(Staff staff)
        {
            _staffDal.Update(staff);
        }
    }
}
