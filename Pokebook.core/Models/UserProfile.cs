using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class UserProfile : EntityBase
    {
        public string ProfilePicture { get; set; }
        public string CoverPicture { get; set; }
        public List<string> Info { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
