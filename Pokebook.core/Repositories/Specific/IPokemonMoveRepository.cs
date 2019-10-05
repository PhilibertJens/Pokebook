using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonMoveRepository : IRepository<PokemonMove>
    {
        //Task<List<PokemonMove>> GetAllPokemonMovesWithMoves();
    }
}
