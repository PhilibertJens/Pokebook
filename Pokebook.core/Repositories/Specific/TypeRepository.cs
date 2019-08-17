using AutoMapper;
using Pokebook.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class TypeRepository : MappingRepository<core.Models.Type>, ITypeRepository
    {
        public TypeRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
