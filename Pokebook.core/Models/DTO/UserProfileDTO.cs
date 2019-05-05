using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class UserProfileDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please provide your First name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Your Firstname must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü]{1,}$", ErrorMessage = "Your Firstname cannot contain whitespaces or special characters")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide your Last name")]
        [StringLength(70, MinimumLength = 2, ErrorMessage = "Your Lastname must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü]{1,}$", ErrorMessage = "Your Lastname cannot contain whitespaces or special characters")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide a Username")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Your Username must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-]{1,}$", ErrorMessage = "Username cannot contain whitespaces or special characters")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
    }
}
