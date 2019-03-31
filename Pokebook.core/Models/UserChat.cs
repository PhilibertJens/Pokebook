using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public class UserChat
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }

        /*Navigation properties*/
        public User User { get; set; }
        public Chat Chat { get; set; }
    }
}
