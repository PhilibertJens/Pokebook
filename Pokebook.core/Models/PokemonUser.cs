using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonUser: EntityBase
    {
        public Guid UserId { get; set; }
        public Guid PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }
        public short Catches { get; set; }
    }
}
