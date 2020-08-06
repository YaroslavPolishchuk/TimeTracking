using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GenericRepository
{
    public interface IGenericRepository<T,Tkey> where T:class,new()
    {
        IEnumerable<T> GetAllData();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Get(Tkey id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Save();
    }
}
