using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonMove: EntityBase
    {
        public Guid PokemonId { get; set; }
        public Guid MoveId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Move Move { get; set; }
    }
}
