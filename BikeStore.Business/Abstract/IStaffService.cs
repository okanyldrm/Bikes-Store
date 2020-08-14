using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IStaffService
    {

        List<Staff> GetAll();
        Staff GetById(int staffId);
        void Add(Staff staff);
        void Delete(Staff staff);
        void Update(Staff staff);


    }
}
