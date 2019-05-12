using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models.DTO
{
    public class FriendshipDTO
    {
        public Guid FriendId { get; set; }
        public Friendship Friendship { get; set; }
    }
}
