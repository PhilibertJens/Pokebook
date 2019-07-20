using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ExploreCatchVm
    {
        public Pokemon AppearedPokemon { get; set; }
        public int HP { get; set; }
        public List<string> Moves { get; set; }
        public string CheatingWarning { get; set; }
        public string UserName { get; set; }
    }
}
