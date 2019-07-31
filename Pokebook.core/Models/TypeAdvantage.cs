using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class TypeAdvantage: EntityBase
    {
        public Guid AdvantageTypeId { get; set; }
        public Guid DisadvantageTypeId { get; set; }

        public Type AdvantageType { get; set; }
        public Type DisadvantageType { get; set; }
    }
}
