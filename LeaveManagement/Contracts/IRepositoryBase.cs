using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        ICollection<TEntity> FindAll();
        TEntity FindById(object id);
        bool Create(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        public bool DeleteById(object Id);
        bool Save();
    }
}
