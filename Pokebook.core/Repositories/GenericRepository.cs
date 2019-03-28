using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public abstract class GenericRepository<T> : IBaseRepository
        where T: EntityBase 
    {
        protected readonly PokebookContext db; //Look into implementation for Identity DbContext
        public GenericRepository(PokebookContext context)
        {
            db = context;
        }
        public int Count { get; set; }
        /// <summary>
        /// Finds all entries in repo, ready for deferred execution
        /// </summary>
        public IQueryable<T> FindAll() => db.Set<T>().AsNoTracking();
        public async Task<T> FindByIdAsync(Guid id) => await db.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> ListAll() => await FindAll().ToListAsync();

        /// <summary>
        /// Only to use for devs, with deferred execution
        /// </summary>
        /// <returns>Datasource which can be queried</returns>
        public IQueryable<T> FindFiltered(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>()
            .Where(predicate).AsNoTracking();
        }
        public async Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate) => await FindFiltered(predicate).ToListAsync();
        public abstract Task<T> AddAsync(T entity);
        public abstract Task<T> UpdateAsync(T entity);
        public abstract Task<T> DeleteAsync(T entity);
        public abstract Task<T> DeleteAsync(Guid id);
    }
}
