using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models.DTO
{
    public class ChatSimpleDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MessageCount { get; set; }
    }
}
