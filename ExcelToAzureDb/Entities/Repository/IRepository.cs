using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetResults();
        T Add(T result);
        void Save();
    }
}
