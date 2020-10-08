﻿using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Entities.Concrete;

namespace BikeStore.Business.Abstract
{
    public interface IUserService
    {

        List<User> GetAll();
        User GetById(int userId);
        void Add(User user);
        void Delete(User user);
        void update(User user);



    }
}
