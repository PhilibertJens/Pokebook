using Pokebook.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class AllChatsForUserVM
    {
        public string Username { get; set; }
        public ICollection<Chat> ListChats { get; set; }
    }
}
