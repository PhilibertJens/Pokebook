using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface IRepository<T>
        where T : EntityBase
    {
        T FindById(Guid id);
        IEnumerable<T> ListAll();
        IEnumerable<T> ListFiltered(Expression<Func<T, bool>> predicate);

        T Add(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);

        T Remove(T entity);
        IEnumerable<T> RemoveRange(IEnumerable<T> entities);

        T Update(T entity);
    }
}
