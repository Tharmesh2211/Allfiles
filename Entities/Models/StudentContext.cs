using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentContext :DbContext
    {
        public StudentContext()
        {

        }
        public StudentContext(DbContextOptions <StudentContext> options) : base(options) { }
        public virtual DbSet<Student> StudentsDetail { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EN72J61\\SQLEXPRESS;Initial Catalog=STUDENTS;Integrated Security=True;TrustServerCertificate=True;");
    }
} 
