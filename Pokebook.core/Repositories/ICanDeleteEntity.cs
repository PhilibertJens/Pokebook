using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface ICanDeleteEntity<T> where T : EntityBase
    {
        Task<T> DeleteAsync(T entity);
        Task<T> DeleteAsync(Guid id);
    }
}
