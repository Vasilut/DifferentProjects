using System.Linq;

namespace Repository.Services
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetResults();
        T Add(T result);
        void Save();
    }
}
