using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Models
{
    public class UserChat : EntityBase
    {
        public Guid ChatId { get; set; }
        public Guid UserId { get; set; }

        /*Navigation properties*/
        public User User { get; set; }
        public Chat Chat { get; set; }
    }
}
