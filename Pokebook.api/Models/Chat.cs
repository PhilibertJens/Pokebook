using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Models
{
    public class Chat : EntityBase
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Theme { get; set; }

        public Guid CreatorId { get; set; }
        public DateTime CreateDate { get; set; }

        public int NumberOfMessages { get; set; }
        public int NumberOfUsers { get; set; }
        public string LastMessage { get; set; }

        /*Navigation properties*/
        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
