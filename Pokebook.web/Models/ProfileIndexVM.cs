using Microsoft.AspNetCore.Http;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ProfileIndexVM
    {
        public User me { get; set; }

        //[Required(ErrorMessage = "No image found")]
        public IFormFile UploadedProfileImage { get; set; }
        public IFormFile UploadedCoverImage { get; set; }

        public string ProfilePicture { get; set; }
        public string CoverPicture { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "The Pokemon name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü ]{1,}$", ErrorMessage = "The Pokemon name cannot special characters")]
        [Display(Name = "Favorite Pokemon")]
        public string FavoritePokemon { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The game's name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü ]{1,}$", ErrorMessage = "The game's name cannot contain special characters")]
        [Display(Name = "Favorite Pokemongame")]
        public string FavoritePokemonGame { get; set; }
    }
}
