using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class Program
    {
    
        static void Main(string[] args)
        {
            Loosely_Coupled loosely_Coupled = new Loosely_Coupled(new StudentMain());
            loosely_Coupled.Call();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - -  - -  - -");

            loosely_Coupled = new Loosely_Coupled(new EmployeeMain());
            loosely_Coupled.Call();
        }
    }
}
