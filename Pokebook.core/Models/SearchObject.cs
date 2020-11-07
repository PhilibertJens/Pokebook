using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class SearchObject
    {
        public List<string> Properties { get; set; }
        public List<string> Values { get; set; }
        public Guid UserId { get; set; }
    }
}
