using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Helpers
{
    public class GeneralFunctions
    {
        public static string EvaluateFolderType(bool isShiny, bool isAlolan)
        {
            if (isShiny && isAlolan) return "Shiny_alolan";
            else if (isShiny) return "Shiny";
            else if (isAlolan) return "Alolan";
            return "Normal";
        }
    }
}
