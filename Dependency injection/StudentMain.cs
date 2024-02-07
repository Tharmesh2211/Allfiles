using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dependency_injection
{
    public class StudentMain : Student,IAbout
    {
        public void Assign()
        {
            Id = 1;
            Name = "Ganesh Pandy";
            Age = 28;
            PhoneNumber = 98653212390;
        }

        public void Print()
        {
            Console.WriteLine("Employee ID   :  " + Id);
            Console.WriteLine("Name          :  " + Name);
            Console.WriteLine("Age           :  " + Age);
            Console.WriteLine("PhoneNumber   :  " + PhoneNumber);
        }
    }
}
