
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GenericRepository
{
    public class GenericRepository<T, Tkey> : IGenericRepository<T, Tkey> where T : class, new()
    {
        DbContext context;
        DbSet<T> dbSet;
        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }
        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }


        public T Get(Tkey id)
        {
            return dbSet.Find(id);
        }
        //public T Get(Expression<Func<T, bool>> expression)
        //{
        //    return dbSet.Find(expression);
        //}

        public IEnumerable<T> GetAllData()
        {
            return dbSet;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            dbSet.Update(obj);
        }
    }
}
