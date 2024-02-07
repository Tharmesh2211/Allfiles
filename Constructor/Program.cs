using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(20, "Tharmesh", 76, 98, 75);
            student.Calculation();
            student.Display();
        }
    }
}
