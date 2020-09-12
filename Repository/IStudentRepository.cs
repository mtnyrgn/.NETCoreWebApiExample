using System;
using System.Linq;

namespace Repository
{
    public interface IStudentRepository<T>
    {
        long Add(T entity);
        void Delete(T entity);
        T Get(long id);
        IQueryable<T> GetAll();
        void Update(T entity);
        void SaveAll();
    }
}
