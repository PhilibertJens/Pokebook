using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public class Message : EntityBase
    {
        public Guid ChatId { get; set; }
        public Guid SenderId { get; set; }

        public string Text { get; set; }
        public string ImageName { get; set; }

        public DateTime SendDate { get; set; }

        /*Navigation properties*/
        public Chat Chat { get; set; }
        public User Sender { get; set; }
    }
}
