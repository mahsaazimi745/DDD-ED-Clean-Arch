using Software_Ar.Core.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace Software_Ar.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _Context;
        //private readonly DbSet<T> _dbset;
        //private readonly DbSet<TEntity> _dbSet;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext Context )
        {
               _Context = Context;
            //DbSet= _dbset;
            _dbSet = _context.Set<T>();
  
        }
       public async Task<IEnumerable<T>> GetAllAsync()
        { 
            yield return ;
        }
        public async Task<T> GetByIdAsync(Object id) 
        {
           return   -dbSet.Find(id);
        }
        public async Task<T> UpdateAsync(T entity) 
        {
            return  _dbSet.Update(entity);
            SavachangeAsync(entity);
        }
       public  async Task<T> DeleteAsync(T entity) 
        {
            return  _dbset.Delete(entity);
        }
     
        public  async Task<T> AddAsync(T entity) 
        {
             return _dbSet.Add(entity);
        }
       public aysinc  Task<bool> SavachangeAsync(T entity);
    }
}
