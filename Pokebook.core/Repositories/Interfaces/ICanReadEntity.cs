using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Interfaces
{
    public interface ICanReadEntity<T> where T : EntityBase
    {
        Task<T> FindByIdAsync(Guid id);
        Task<IEnumerable<T>> ListAll();
        Task<IEnumerable<T>> ListFiltered(Expression<Func<T, bool>> predicate);
    }
}
