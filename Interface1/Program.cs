using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            //CommonData student = new Student(1, "Tharmesh", 21, 9087564123, new DateTime(2002, 11, 22));
            //student.PrintData();

            ExtraInfo employee = new Employee(5, "Jeeva", 34, 9876543219, new DateTime(2000, 7, 17), 500000);
            employee.Calculate();
            employee.PrintData();
        }
    }
}
