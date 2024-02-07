using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Code_First_Approach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
      
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime date { get; set; } = new DateTime();
        [Required]
      
        public long PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
