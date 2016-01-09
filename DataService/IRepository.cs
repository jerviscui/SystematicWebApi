using System.Data.Entity;
using Domain;

namespace DataService
{
    /// <summary>
    /// basic operation: CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        IDbSet<T> Table { get; }

        void Add(T model);

        void Update(T model);

        void Delete(T model);
    }
}
