using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class PokedexPokemonVM
    {
        public Pokemon SelectedPokemon { get; set; }
        public short Catches { get; set; }
        public StringBuilder Sb { get; set; }
        public string[] Colors { get; set; }
    }
}
