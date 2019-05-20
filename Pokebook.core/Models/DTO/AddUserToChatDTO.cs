using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class AddUserToChatDTO
    {
        public Guid ChatId { get; set; }
        public List<string> Users { get; set; }
    }
}
