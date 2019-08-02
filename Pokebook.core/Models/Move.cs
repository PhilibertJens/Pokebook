using System;
using System.Collections.Generic;

namespace Pokebook.core.Models
{
    public class Move: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Generation { get; set; }
        public Guid TypeId { get; set; }

        public ICollection<PokemonMove> PokemonMoves { get; set; } //verbinding met moves voor Pokemon sjabloon
        public ICollection<PokemonMoveCatch> PokemonMoveCatches { get; set; } //verbinding met moves voor caught Pokemon
        public Type Type { get; set; }
    }
}