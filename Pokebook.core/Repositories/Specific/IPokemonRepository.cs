using Pokebook.core.Models;
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
        Task<Pokemon> GetFullPokemon(Guid id);
    }
}
