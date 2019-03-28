using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : EntityBase
    {
        protected readonly PokebookContext db;
        public GenericRepository(PokebookContext context)
        {
            db = context;
        }
        public int Count { get; set; }

        public IQueryable<T> FindAll() => db.Set<T>().AsNoTracking();
        public async Task<T> FindByIdAsync(Guid id) => await db.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> ListAll() => await FindAll().ToListAsync();
        public IQueryable<T> FindFiltered(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>()
            .Where(predicate).AsNoTracking();
        }
        public async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate) => await FindFiltered(predicate).ToListAsync();
        public async Task<T> AddAsync(T entity)
        {
            db.Set<T>().Add(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }
        public async Task<T> Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return null;
            }
            return entity;
        }
        public async Task<T> Delete(Guid id)
        {
            var entity = await FindByIdAsync(id);
            if (entity == null) return null;
            return await Delete(entity);
        }
    }
}
