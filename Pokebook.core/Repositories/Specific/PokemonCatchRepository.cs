using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonCatchRepository : MappingRepository<PokemonCatch>, IPokemonCatchRepository
    {
        public PokemonCatchRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public Task<Pokemon> CreateByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
