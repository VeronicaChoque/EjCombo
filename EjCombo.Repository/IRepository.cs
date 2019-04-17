using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EjCombo.Repository
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void Edit(T entity);
        T Find(int id);
        IEnumerable<T> Find(Expression<Func<T,bool>>predicate);
       
    }
}
