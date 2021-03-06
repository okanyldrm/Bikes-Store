﻿using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        Brand GetById(int brandId);
        void Add(Brand brand);
        void Delete(Brand brand);
        void update(Brand brand);



    }
}
