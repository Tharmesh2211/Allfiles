using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student:Person,IStudent
    {
        public string StudentId {  get; set; }
        public Student(string FirstName, string LastName, int Age, string Gender, long ContactNumber, string StudentId)
                 :base(FirstName, LastName, Age, Gender, ContactNumber)
        {
            this.StudentId = StudentId;
        }

        public override void DisplayDetails()
        {
            string Value ="  FirstName  : " + FirstName + "  LastName  : " + LastName + "  Age  :  " + Age +
                           "  Gender  : " + Gender + "  ContactNumber  :  " + ContactNumber;

            Console.WriteLine(Value);
        }

        public void EnrollCourse()
        {
            Console.WriteLine("Course Enrolled Successfully !");
        }

        public void SubmitAssignment()
        {
            Console.WriteLine("Assignment Submitted Successfully !");
        }

        public string GetStudentID()
        {
            return StudentId;
        }
    }
}
