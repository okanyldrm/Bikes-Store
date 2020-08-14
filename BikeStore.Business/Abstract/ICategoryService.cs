using BikeStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStore.Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetAll();
        Category GetById(int categoryId);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);



    }
}
