using BikeStore.Core.DataAccess;
using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {

        //Complex type or Categry specific Func Def...


    }
}
