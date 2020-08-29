using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonCatchRepository : IRepository<PokemonCatch>
    {
        Task<List<PokemonCatch>> GetAllCaughtPokemon(Guid userId);
        Task<List<Guid>> GetAllGuids(Guid userId);
        Task<PokemonCatch> CreateByName(string name);
        PokemonCatch CreateFromTemplate(Pokemon template, Guid userId);
        Guid AddPokemonCatch(PokemonCatch pokemon);
        Task<List<PokemonCatch>> GetPokemonCatchesWithProperty(SearchObject obj);
    }
}
