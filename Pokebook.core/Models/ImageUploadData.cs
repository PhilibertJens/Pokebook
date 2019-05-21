using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokebook.core.Models
{
    public class ImageUploadData
    {
        public string Uri { get; set; }
        public string FileName { get; set; }
        public Stream Image { get; set; }
    }
}
