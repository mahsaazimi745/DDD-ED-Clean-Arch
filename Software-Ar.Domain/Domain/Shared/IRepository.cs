using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Ar.Core.Domain.Shared
{
    public interface IRepository<T>  where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAssync(object id );
       Task<T> UpdateAsync( T entity );
        Task<T> DeleteAsync( T entity);
        Task<T> CreateAsync( T entity );
        Task<T> AddAsync(T entity);
        Task<bool>SavachangeAsync(T entity);
    }
}
