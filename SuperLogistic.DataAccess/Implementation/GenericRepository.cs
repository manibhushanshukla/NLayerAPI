using SuperLogistic.DataAccess.Context;
using SuperLogistic.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        public GenericRepository(DataContext context)
        {
            _context = context;
            
        }
        void IGenericRepository<T>.Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        IEnumerable<T> IGenericRepository<T>.Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            return _context.Set<T>().ToList();
        }

        T IGenericRepository<T>.GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        void IGenericRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
