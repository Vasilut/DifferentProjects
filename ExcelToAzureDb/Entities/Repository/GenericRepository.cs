using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entities.Repository
{
    public class GenericRepository<C, T> : IRepository<T> where T : class where C : DbContext, new()
    {
        private C _entities = new C();
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }
        public virtual T Add(T result)
        {
            _entities.Set<T>().Add(result);
            return result;

        }

        public virtual IQueryable<T> GetResults()
        {
            return _entities.Set<T>();
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
