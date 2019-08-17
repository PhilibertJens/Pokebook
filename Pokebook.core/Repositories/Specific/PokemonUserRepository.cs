using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonUserRepository : MappingRepository<PokemonUser>, IPokemonUserRepository
    {
        public PokemonUserRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
