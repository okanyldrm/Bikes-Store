using BikeStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace BikeStore.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<T, TContext> : IRepository<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        //GetList
        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }
        //Get
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }
        //Add
        public void Add(T entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        //Delete
        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        //Update
        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }

  
}
