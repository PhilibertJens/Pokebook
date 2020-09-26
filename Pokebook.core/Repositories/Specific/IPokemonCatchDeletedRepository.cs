using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Repositories.Specific
{
    public interface IPokemonCatchDeletedRepository : IRepository<PokemonCatchDeleted>
    {

        Guid AddPokemonCatchDeleted(PokemonCatch toDelete);
    }
}
