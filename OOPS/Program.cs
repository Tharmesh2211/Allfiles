using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Employ employ = new Employ();
            employ.Name = "Tharmeshwaran";
            employ.Id = 100;
            employ.Salary = 12000;
            employ.Print();
            Console.WriteLine("-------------------------------");
            //Student student = new Student();
            //student.Student_Name = "Parthiban";
            //student.Student_Email = "parthi@gmail.com";
            //student.Student_Age = 27;
            //student.Details();
            //Console.WriteLine("-------------------------------");
        }
    }
}
