using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Pokebook.core.Models.Type;

namespace Pokebook.core.Repositories.Specific
{
    public class TypeRepository : MappingRepository<Type>, ITypeRepository
    {
        public TypeRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Type> FindTypeByIdAsync(Guid Id)
        {
            return await PokebookContext.Types.FindAsync(Id);
        }

        public async Task<Type> FindTypeByTypeNameAsync(string typeName)
        {
            return await PokebookContext.Types.Where(t => t.Name.Equals(typeName)).FirstOrDefaultAsync();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
