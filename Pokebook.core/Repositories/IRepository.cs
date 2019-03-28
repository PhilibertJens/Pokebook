using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface IRepository<T> : IBaseRepository //already inherits 'Count'
        where T : EntityBase
    {
        Task<T> FindByIdAsync(Guid id);
        IQueryable<T> FindAll();
        Task<IEnumerable<T>> ListAll();
        IQueryable<T> FindFiltered(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
        Task<T> AddAsync(T entity);
        Task<T> Delete(T entity);
        Task<T> Delete(Guid id);
        Task<T> UpdateAsync(T entity);
    }
}
