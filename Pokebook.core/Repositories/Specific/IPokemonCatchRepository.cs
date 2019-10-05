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
        Task<PokemonCatch> CreateByName(string name);
        PokemonCatch CreateFromTemplate(Pokemon template, Guid userId);
        Guid AddPokemonCatch(PokemonCatch pokemon);
    }
}
