using EjCombo.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EjCombo.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Edit(T entity)
        {
            context.SaveChanges();
        }

        public T Find(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
        }

    }
}
