using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class Type: EntityBase
    {
        public string Name { get; set; }
        public ICollection<PokemonType> PokemonTypes { get; set; }
        public string Colour { get; set; }

        public ICollection<Type> Advantages { get; set; }
        public ICollection<Type> Disadvantages { get; set; }
    }
}
