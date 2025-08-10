using Software_Ar.Core.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Linq.Expressions;


namespace Software_Ar.Infrastructure.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        //private readonly DbSet<T> _dbset;
        //private readonly DbSet<TEntity> _dbSet;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext Context)
        {
            _context = Context;
            //DbSet= _dbset;
            _dbSet = _context.Set<T>();
        }
 
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //return await _dbSet.ToListAsync();
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        /*  public async Task<T> GetByIdAsync(Object id) 
          {
              //return  await -dbSet.FindAsync(id);
              return await _dbSet.FindAsync(id);
          }*/
        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<T> UpdateAsync(T entity) 
        {
            //return  _dbSet.Update(entity);
            //SavachangeAsync(entity);
            _dbSet.Update(entity);
            await SaveChangeAsync();
            return entity;
        }
       public  async Task<T> DeleteAsync(T entity) 
        {
            //await _dbSet.DeleteAsync(entity);
            //return entity;
            _dbSet.Remove(entity);
            await SaveChangeAsync();
            return entity;
        }
     
        public  async Task<T> AddAsync(T entity) 
        {
            //return _dbSet.Add(entity);
            await _dbSet.AddAsync(entity);
            await SaveChangeAsync();
            return entity;
        }
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }
        //public aysinc  Task<bool> SavachangeAsync(T entity);

        public async Task<bool> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
