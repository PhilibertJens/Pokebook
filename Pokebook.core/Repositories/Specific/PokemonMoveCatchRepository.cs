using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public class PokemonMoveCatchRepository : MappingRepository<PokemonMoveCatch>, IPokemonMoveCatchRepository
    {
        public PokemonMoveCatchRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId(Guid id)
        {
            List<PokemonMoveCatch> pokemonMoveCatches = await PokebookContext.PokemonMoveCatches.Where(pmc => pmc.PokemonId == id)
                                                                             .Select(pmc => new PokemonMoveCatch {PokemonId = pmc.PokemonId,
                                                                                                                  MoveId = pmc.MoveId })
                                                                             .ToListAsync();
            return pokemonMoveCatches;
        }

        public async Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId_Full(Guid id)
        {
            List<PokemonMoveCatch> pokemonMoveCatches = await PokebookContext.PokemonMoveCatches.Where(pmc => pmc.PokemonId == id).ToListAsync();
            return pokemonMoveCatches;
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
