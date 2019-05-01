using Microsoft.AspNetCore.Mvc.Rendering;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ChatIndexVM
    {
        public UserSimpleDTO User { get; set; }

        [Required]
        public Guid SelectedUserId { get; set; }
        public SelectList AllUsers { get; set; }
    }
}
