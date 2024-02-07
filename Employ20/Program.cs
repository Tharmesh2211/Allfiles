using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employ20
{
    internal class Program
    {
        static void Details(int ID=5, string empname="kumaran", string email="kumaran@gmail.com", string address="2G Colony", float salary=78000)
        {
            Console.WriteLine("Employ ID    : "+ID);
            Console.WriteLine("Employ Name  : "+empname);
            Console.WriteLine("Employ Email : "+email);
            Console.WriteLine("Employ Address : "+address);
            Console.WriteLine("Employ Salary  : "+salary);
        }
        static void Main(string[] args)
        {
            int ID = 10;
            float sal = 6500.45f;
            Details(ID, "","","",sal);
        }
    }
}
