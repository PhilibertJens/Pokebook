using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonMoveCatchDeleted: EntityBase
    {
        public Guid PokemonId { get; set; }
        public Guid MoveId { get; set; }

        public DateTime Deleted { get; set; }

        //public PokemonCatch Pokemon { get; set; }
        public Move Move { get; set; }
    }
}
