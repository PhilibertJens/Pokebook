using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonMoveCatchRepository
    {
        Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId(Guid id);
        Task<List<PokemonMoveCatch>> GetAllByPokemonCatchId_Full(Guid id);
    }
}
