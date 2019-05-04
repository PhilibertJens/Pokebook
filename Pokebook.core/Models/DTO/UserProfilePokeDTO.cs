using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class UserProfilePokeDTO
    {
        public Guid Id { get; set; }
        public string FavoritePokemon { get; set; }
        public string FavoritePokemonGame { get; set; }
    }
}
