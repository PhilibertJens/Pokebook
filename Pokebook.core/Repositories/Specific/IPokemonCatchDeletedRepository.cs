using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonCatchDeletedRepository : IRepository<PokemonCatchDeleted>
    {
        Task<List<PokemonCatchDeleted>> GetAllPokemonCatchDeleted(Guid userId);
        Task<List<Guid>> GetAllGuids(Guid userId);

        Guid AddPokemonCatchDeleted(PokemonCatch toDelete);
    }
}
