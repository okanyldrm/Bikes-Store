using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Core.DataAccess;
using BikeStore.Entities.Concrete;

namespace BikeStore.DataAccess.Abstract
{
    public interface IUserDal : IRepository<User>
    {
    }
}
