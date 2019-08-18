using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonTypeRepository: IRepository<PokemonType>
    {
        Task<List<Pokemon>> GetPokemonListByTypeName(string typeName);
    }
}
