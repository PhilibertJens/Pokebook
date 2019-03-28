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

        public Task<T> Add(T entity) => throw new NotImplementedException();
        public Task<T> Delete(T entity) => throw new NotImplementedException();
        public Task<T> Delete(Guid id) => throw new NotImplementedException();
        public IQueryable<T> GetAll() => throw new NotImplementedException();
        public Task<T> GetById(Guid id) => throw new NotImplementedException();
        public IQueryable<T> GetFiltered(Expression<Func<T, bool>> predicate) => throw new NotImplementedException();
        public Task<IEnumerable<T>> ListAll() => throw new NotImplementedException();
        public Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate) => throw new NotImplementedException();
        public Task<T> Update(T entity) => throw new NotImplementedException();
    }
}
