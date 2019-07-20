using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonType: EntityBase
    {
        public Guid PokemonId { get; set; }
        public Guid TypeId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Type Type { get; set; }
    }
}
