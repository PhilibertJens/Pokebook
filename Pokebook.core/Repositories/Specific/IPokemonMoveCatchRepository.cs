using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonMoveCatchRepository
    {
        Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId(Guid id);
        Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId_Full(Guid id);
        Guid AddPokemonMoveCatch(PokemonMoveCatch moveCatch);
    }
}
