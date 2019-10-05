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
    public class PokemonMoveRepository : MappingRepository<PokemonMove>, IPokemonMoveRepository
    {
        public PokemonMoveRepository(PokebookContext context, IMapper mapper) : base(context, mapper)
        {
        }

        /*public async Task<List<PokemonMove>> GetAllPokemonMovesWithMoves()
        {
            return await PokebookContext.PokemonMoves.Include(pm => pm.Move).ToListAsync();
        }*/

        public PokebookContext PokebookContext
        {
            get { return db as PokebookContext; }
        }
    }
}
