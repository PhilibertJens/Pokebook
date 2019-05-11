using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class FriendWithFriendshipDTO
    {
        public User Friend { get; set; }
        public Friendship Friendship { get; set; }
    }
}
