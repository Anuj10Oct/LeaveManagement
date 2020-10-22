using LeaveManagement.Contracts;
using LeaveManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return Save();
        }

        public bool Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return Save();
        }

        public bool DeleteById(object Id)
        {
            bool result = false;
            var entity = _context.Set<TEntity>().Find(Id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                result = Save();
            }
            return result;
        }

        public ICollection<TEntity> FindAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity FindById(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return Save();
        }
    }
}
