using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebook.core.Models
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        private DateTime? created;
        public DateTime? Created
        {
            get
            {
                return created ?? DateTime.Now;
            }
            set
            {
                if (value != null)
                    created = value;
                else created = DateTime.Now;
            }
        }
    }
}
