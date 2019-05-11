using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class HomeIndexVM
    {
        public User Me { get; set; }
        public List<User> FriendsToApprove { get; set; }
    }
}
