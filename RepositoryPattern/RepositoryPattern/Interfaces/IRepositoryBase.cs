using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Delete(Guid entityId);
        void Save();
    }
}
