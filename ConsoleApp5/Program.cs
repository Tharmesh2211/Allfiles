using System;
namespace employee
{
    internal class Contract
    {
        string name = "tharmesh";
        string age = "22";
        string ID = "100";

        static void EmployeeType()
        {
            Console.WriteLine("Contract Employee");
        }
    }
    internal class Temporary
    {
        string name = "jeeva";
        string age = "39";
        string ID = "103";

        static void EmployeeType()
        {
            Console.WriteLine("Temporary Employee");
        }
    }

     internal class Permanent
    {
        string name = "Ananth";
        string age = "56";
        string ID = "123";
        string phno = "9887654321";
        
        static void EmployeeType()
        {
            Console.WriteLine("Permanent Employee");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
//      new employee.Permanent().EmployeeType();
    }
}
