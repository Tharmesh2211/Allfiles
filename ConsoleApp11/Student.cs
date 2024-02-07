using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Student
    {
        public int Roll_Number { get; set; } = 1;
        public string Student_Name { get; set; }
        public string Student_Gender {  get; set; }
        public DateTime Student_DOB { get; set;}
        public string Student_Address {  get; set; }
        public char Student_Grade {  get; set; }
        public bool IsDelete { get; set; } = true;
        public int Teacher_ID {  get; set; }

    }
}