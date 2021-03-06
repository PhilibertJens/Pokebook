﻿using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ChatSendFirstMessageVM
    {
        public Guid SenderId { get; set; }
        public UserSimpleDTO Sender { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "The message must be between {2} and {1} characters")]
        //[Display(Name = "Username")]
        public string Text { get; set; }
        public DateTime SendDate { get; set; }
        public UserSimpleDTO Receiver { get; set; }
    }
}
