using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories
{
    public interface ICanUpdateEntity<T> where T : EntityBase
    {
        Task<T> UpdateAsync(T entity);
    }
}
