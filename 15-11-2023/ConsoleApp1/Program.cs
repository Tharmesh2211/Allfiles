using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Tharmesh", "Waran", 21, "Male", 9087654321, "200");
            student.EnrollCourse();
            Console.Write("Student ID  :  "+student.GetStudentID());
            student.DisplayDetails();
            student.SubmitAssignment();

        }
    }
}
