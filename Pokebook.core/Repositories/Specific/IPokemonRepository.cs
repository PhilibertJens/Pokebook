using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonRepository : IRepository<Pokemon>
    {
        Task<Pokemon> GetByName(string name);
        Task<Pokemon> GetByNdex(int ndex);
        Task<Pokemon> GetWithType(Guid id);
        Task<List<Pokemon>> GetAllWithType();
        Task<List<string>> GetAllNames();
        Task<Pokemon> GetFullPokemon(Guid id);
        Task<PokemonSimpleDTO> GetPokemonSimple(Guid id);
        Task<PokemonSimpleDTO> GetPokemonSimple(string name);
        Task<List<Pokemon>> GetPokemonWithProperty(SearchObject obj);
    }
}
