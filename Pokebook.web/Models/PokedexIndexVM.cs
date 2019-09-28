using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class PokedexIndexVM
    {
        public IEnumerable<Pokemon> AllPokemonWithTypeInfo { get; set; }
        public string Username { get; set; }
        public IEnumerable<PokemonCatch> AllCaughtPokemon { get; set; }
    }
}
