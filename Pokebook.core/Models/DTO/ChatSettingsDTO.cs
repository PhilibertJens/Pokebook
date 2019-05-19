using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class ChatSettingsDTO
    {
        public Guid ChatId { get; set; }

        [Required(ErrorMessage = "Please provide a chat name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The chat name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü, ]{1,}$", ErrorMessage = "The chat name cannot contain special characters")]
        [Display(Name = "Chat name")]
        public string ChatName { get; set; }
        public string ChatImage { get; set; }
        //later kunnen hier nog properties aan toegevoegd worden
    }
}
