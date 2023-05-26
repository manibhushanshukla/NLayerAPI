using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
     
            Task<T> GetByIdAsync(Guid id);
            Task<IEnumerable<T>> GetAllAsync();
            Task AddAsync(T entity);
            Task UpdateAsync(T entity);
            Task DeleteAsync(T entity);
            Task SaveChangesAsync();
    }
}
