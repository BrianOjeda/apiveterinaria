using Dominio.contracts;
using Dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dominio.implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {


        private readonly bdVeterinariaContext bdVeterinariaContext;

        public Repository(bdVeterinariaContext context)
        {
            this.bdVeterinariaContext = context;
        }
        public void Add(T entity)
        {
            this.bdVeterinariaContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.bdVeterinariaContext.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            this.bdVeterinariaContext.Set<T>().Update(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = bdVeterinariaContext.Set<T>().Where(predicate);
            return query;

        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = bdVeterinariaContext.Set<T>();
            return query;

        }

        public void Save()
        {
            bdVeterinariaContext.SaveChanges();
        }
    }
}
