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

        public ICollection<TypeAdvantage> AdvantagesOver { get; set; }
        public ICollection<TypeAdvantage> DisadvantagesOver { get; set; }
    }
}
