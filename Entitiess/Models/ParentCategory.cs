using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Models
{
  
    public class ParentCategory
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public ParentCategoryEnum Parent_Category_Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

}
