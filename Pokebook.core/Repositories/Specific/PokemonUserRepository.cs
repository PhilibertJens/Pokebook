using AutoMapper;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonUserRepository : MappingRepository<PokemonUser>, IPokemonUserRepository
    {
        public PokemonUserRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public PokemonUser GetPokemonUserById(Guid pokemonId, Guid userId)
        {
            return PokebookContext.PokemonUsers
                            .Where(pu => pu.UserId == userId && pu.PokemonId == pokemonId).FirstOrDefault();
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
