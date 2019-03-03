using System.Linq;

namespace Service.Data
{
    public interface IRepository<T>
    {
        T Return(object id);
        int Create(T entity);
        IQueryable<T> Table { get; }
    }
}