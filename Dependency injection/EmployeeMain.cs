using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dependency_injection
{
    public class EmployeeMain : Employee,IAbout
    {
        public void Assign()
        {
            EmployeeID = 1;
            Name = "Tharmesh";
            Role = "Developer";
            Age = 21;
            PhoneNumber = 9087654321;
        }

        public void Print()
        {
            Console.WriteLine("Employee ID   :  "+EmployeeID);
            Console.WriteLine("Name          :  "+Name);
            Console.WriteLine("Role          :  "+Role);
            Console.WriteLine("Age           :  "+Age);
            Console.WriteLine("PhoneNumber   :  "+PhoneNumber);
        }
    }
}
