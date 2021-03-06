﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class AccountLoginVM
    {
        [Required(ErrorMessage = "Please enter your Username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
