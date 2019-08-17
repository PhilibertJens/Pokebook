using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Type = Pokebook.core.Models.Type;

namespace Pokebook.core.Repositories.Specific
{
    public interface ITypeRepository : IRepository<Type>
    {
        Task<Type> FindTypeByIdAsync(Guid Id);
        Task<Type> FindTypeByTypeNameAsync(string typeName);
    }
}
