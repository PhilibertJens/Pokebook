using Microsoft.AspNetCore.Http;
using Pokebook.core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.web.Models
{
    public class ProfileIndexVM
    {
        public User me { get; set; }

        [Required(ErrorMessage = "No image found")]
        public IFormFile UploadedImage { get; set; }
    }
}
