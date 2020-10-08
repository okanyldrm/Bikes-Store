using System;
using System.Collections.Generic;
using System.Text;
using BikeStore.Business.Abstract;
using BikeStore.DataAccess.Abstract;
using BikeStore.Entities.Concrete;

namespace BikeStore.Business.Concrete.Managers
{
    public class UserManager :IUserService
    {

        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            var users = _userDal.GetList();
            return users;
        }

        public User GetById(int userId)
        {
            var user = _userDal.Get(u => u.user_id==userId);
            return user;
        }

        public void Add(User user)
        {
           _userDal.Add(user);
        }

        public void Delete(User user)
        {
           _userDal.Delete(user);
        }

        public void update(User user)
        {
           _userDal.Update(user);
        }
    }
}
