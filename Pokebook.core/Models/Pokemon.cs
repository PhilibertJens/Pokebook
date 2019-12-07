using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class Pokemon: EntityBase
    {
        public short NDex { get; set; } //National Index N°
        public string Name { get; set; }
        public bool HasAlolanForm { get; set; }
        public string ImgUrl { get; set; }
        public string ImgUrlShiny { get; set; }
        public string ImgUrlAlolan { get; set; }
        public string ImgUrlShiny_Alolan { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsLegendary { get; set; }
        public bool IsMythical { get; set; }
        public ICollection<PokemonEvolution> PokemonEvolutions { get; set; }
        public ICollection<PokemonEvolution> PokemonPreEvolutions { get; set; }
        public ICollection<PokemonType> PokemonTypes { get; set; }

        /*sjabloon data*/
        public int MinHP { get; set; }
        public int MaxHP { get; set; }
        public int MinCP { get; set; }
        public int MaxCP { get; set; }
        public float MinWeight { get; set; }
        public float MaxWeight { get; set; }
        public float MinHeight { get; set; }
        public float MaxHeight { get; set; }
        public ICollection<PokemonMove> PokemonMoves { get; set; }
    }
}
