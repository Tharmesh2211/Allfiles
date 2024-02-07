using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Models
{
    public class FilesUploads
    {
        public int ImgId { get; set; }
        public IFormFile? Parent_Category_File { get; set; }
        public string? ImageName { get; set; }
    }
}
