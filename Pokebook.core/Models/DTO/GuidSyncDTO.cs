using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class GuidSyncDTO
    {
        public Guid UserId { get; set; }

        public List<Guid> PokemonCatches { get; set; }
    }
}
