using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public class Chat : EntityBase
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Theme { get; set; }

        public Guid CreatorId { get; set; }
        public DateTime CreateDate { get; set; }

        public int NumberOfMessages { get; set; }
        public int NumberOfUsers { get; set; }
        public string LastMessage { get; set; }

        /*Navigation properties*/
        [JsonIgnore]
        public ICollection<UserChat> UserChats { get; set; }
        [JsonIgnore]
        public ICollection<Message> Messages { get; set; }
    }
}
