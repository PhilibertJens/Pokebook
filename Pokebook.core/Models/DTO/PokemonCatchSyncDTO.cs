using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class PokemonCatchSyncDTO
    {
        public Guid UserId { get; set; }

        public List<PokemonCatch> PokemonCatches { get; set; }

        public List<PokemonMoveCatch> PokemonMoveCatches { get; set; }
    }
}
