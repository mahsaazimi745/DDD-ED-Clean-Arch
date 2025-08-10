using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared
{
    public interface IRepository<T>  where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id );
       Task<T> UpdateAsync( T entity );
        Task<T> DeleteAsync( T entity);
        Task<T> AddAsync(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
      
        //Task<bool>SavachangeAsync(T entity);
        Task<bool> SaveChangeAsync();
    }
}
