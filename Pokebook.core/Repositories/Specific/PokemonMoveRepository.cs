using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonMoveRepository : MappingRepository<PokemonMove>, IPokemonMoveRepository
    {
        public PokemonMoveRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
