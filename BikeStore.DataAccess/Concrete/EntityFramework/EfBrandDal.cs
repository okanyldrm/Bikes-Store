﻿using BikeStore.Core.DataAccess.EntityFramework;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfRepositoryBase<Brand,BikeStoreContext> , IBrandDal
    {
    }
}
