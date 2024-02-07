using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {
        public string Student_Name {  get; set; }
        public string Student_Email { get; set; }
        public int Student_Age { get; set; }

        public void Details() 
        {
            Console.WriteLine("Student Name   : "+Student_Name);
            Console.WriteLine("Student Email  : "+Student_Email);
            Console.WriteLine("Student Age    : "+Student_Age);
        }
    }
}
