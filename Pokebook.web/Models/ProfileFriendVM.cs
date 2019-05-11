using Microsoft.AspNetCore.Http;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ProfileFriendVM
    {
        public User Me { get; set; }
        public User Friend { get; set; }

        public ICollection<User> FriendsOfFriend { get; set; }

        public Friendship Friendship { get; set; }
    }
}
