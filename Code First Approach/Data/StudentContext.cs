using Code_First_Approach.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Code_First_Approach.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() { }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public virtual DbSet<Student> StudentDetail { get; set; }

    }
}
