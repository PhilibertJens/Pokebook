using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Interfaces
{
    public interface ICanCreateEntity<T> where T : EntityBase
    {
        Task<T> AddAsync(T entity);
    }
}
