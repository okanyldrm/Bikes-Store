using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Core.DataAccess.EntityFramework;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;

namespace BikeStore.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User,BikeStoreContext> , IUserDal
    {

    }
}
