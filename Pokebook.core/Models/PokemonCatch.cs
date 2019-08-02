using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class PokemonCatch: EntityBase
    {
        public Guid PokemonId { get; set; }
        public Guid UserId { get; set; }

        public int HP { get; set; }
        public int CP { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        

        /*Navigation properties*/
        public Pokemon Pokemon { get; set; }
        public User User { get; set; }
        public ICollection<PokemonMoveCatch> PokemonMoveCatches { get; set; }
    }
}
