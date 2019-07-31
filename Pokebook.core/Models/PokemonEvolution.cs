using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonEvolution: EntityBase
    {
        public Guid BasePokemonId { get; set; }
        public Guid EvolutionId { get; set; }

        public Pokemon BasePokemon { get; set; }
        public Pokemon Evolution { get; set; }
    }
}
