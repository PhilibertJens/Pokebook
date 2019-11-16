using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ExploreCatchVm
    {
        public PokemonCatch AppearedPokemon { get; set; }
        public string CheatingWarning { get; set; }
        public string UserName { get; set; }
        public string BaseUri { get; set; }//is nodig voor partial views
        public string FolderType { get; set; }//is nodig voor partial views
    }
}
