using Pokebook.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
    }
}
