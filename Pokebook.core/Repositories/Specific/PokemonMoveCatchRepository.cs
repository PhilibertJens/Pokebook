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

        public Guid AddPokemonMoveCatch(PokemonMoveCatch moveCatch)
        {//wordt momenteel niet gebruikt
            PokebookContext.PokemonMoveCatches.Add(moveCatch);
            PokebookContext.SaveChanges();
            return moveCatch.Id;
        }

        public Guid DeletePokemonMoveCatch(PokemonMoveCatch pokemonMoveCatch)
        {
            PokebookContext.PokemonMoveCatches.Remove(pokemonMoveCatch);
            PokebookContext.SaveChanges();
            return pokemonMoveCatch.Id;
        }

        public Guid DeleteRangePokemonMoveCatches(List<PokemonMoveCatch> pokemonMoveCatches)
        {
            foreach (PokemonMoveCatch moveCatch in pokemonMoveCatches) DeletePokemonMoveCatch(moveCatch);
            return Guid.Parse("00000000-0000-0000-0000-000000000001");//voorlopig
        }

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
