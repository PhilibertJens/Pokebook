using System;
using System.Collections.Generic;

namespace Pokebook.core.Models
{
    public class Move: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Generation { get; set; }

        public ICollection<PokemonMove> PokemonMoves { get; set; }
        public ICollection<Type> Types { get; set; }
    }
}