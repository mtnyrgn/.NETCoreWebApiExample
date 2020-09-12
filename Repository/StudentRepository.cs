using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class StudentRepository<T> : IStudentRepository<T> where T : BaseEntity
    {
        private readonly StudentContext _context;
        private readonly DbSet<T> entities;

        public StudentRepository(StudentContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        #region sync functions
        public long Add(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("Entity is null!");
            }
            _context.Add(entity);
            return entity.Id;
        }

        public void Delete(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("Entity is null");
            }
            entity.isDelete = true;
            _context.Update(entity);
        }

        public void Update(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("Entity is null");
            }
            _context.Update(entity);
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }
        #endregion

    }
}
