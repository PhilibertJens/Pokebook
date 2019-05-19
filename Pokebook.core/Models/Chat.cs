using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public class Chat : EntityBase
    {
        [Required(ErrorMessage = "Please provide a chat name")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The chat name must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d-\.áéÁÉèàâêîôûäëïöü, ]{1,}$", ErrorMessage = "The chat name cannot contain special characters")]
        [Display(Name = "Chat name")]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Theme { get; set; }

        public Guid CreatorId { get; set; }
        public DateTime CreateDate { get; set; }

        public int NumberOfMessages { get; set; }
        public int NumberOfUsers { get; set; }
        public string LastMessage { get; set; }

        /*Navigation properties*/
        [JsonIgnore]
        public ICollection<UserChat> UserChats { get; set; }
        [JsonIgnore]
        public ICollection<Message> Messages { get; set; }
    }
}
