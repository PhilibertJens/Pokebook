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
        protected readonly DbContext db; //Look into implementation for Identity DbContext
        public GenericRepository(DbContext context)
        {
            db = context;
        }
        
        public T FindById(Guid id) => db.Set<T>().Find(id);

        private IQueryable<T> FindAll() => db.Set<T>().AsNoTracking();
        public IEnumerable<T> ListAll() => FindAll().ToList();

        private IQueryable<T> FindFiltered(Expression<Func<T, bool>> predicate) => db.Set<T>().Where(predicate).AsNoTracking();
        public IEnumerable<T> ListFiltered(Expression<Func<T, bool>> predicate) => FindFiltered(predicate).ToList();



        public virtual T Add(T entity)
        {
            db.Set<T>().Add(entity);
            return entity;
        }

        public virtual IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            db.Set<T>().AddRange(entities);
            return entities;
        }

        public virtual T Remove(T entity)
        {
            db.Set<T>().Remove(entity);
            return entity;
        }

        public virtual IEnumerable<T> RemoveRange(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
            return entities;
        }
    }
}
