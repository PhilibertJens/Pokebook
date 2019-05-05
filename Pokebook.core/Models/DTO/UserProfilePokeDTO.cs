using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class UserProfilePokeDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "The Pokemon name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü ]{1,}$", ErrorMessage = "The Pokemon name cannot special characters")]
        public string FavoritePokemon { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The game's name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü ]{1,}$", ErrorMessage = "The game's name cannot contain special characters")]
        public string FavoritePokemonGame { get; set; }
    }
}
