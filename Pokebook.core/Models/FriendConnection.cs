﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokebook.core.Models
{
    public class FriendConnection: EntityBase
    {
        public Guid IdRequester { get; set; }
        public Guid IdApprover { get; set; }

        public bool Accepted { get; set; }
    }
}
