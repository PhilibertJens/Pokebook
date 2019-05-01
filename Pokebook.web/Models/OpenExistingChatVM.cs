using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class OpenExistingChatVM
    {
        public Chat Chat { get; set; }
        public string Username { get; set; }
        public string Text { get; set; }
        public UserSimpleDTO Me { get; set; }
        public Guid Id { get; set; }
    }
}
