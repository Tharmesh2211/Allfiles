using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {


            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            List<Employee> employees = null;
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("          CRUD OPERATION            ");
                Console.WriteLine("====================================");
                Console.WriteLine("  1.  CREATE                        ");
                Console.WriteLine("  2.  READ                          ");
                Console.WriteLine("  3.  UPDATE                        ");
                Console.WriteLine("  4.  DELETE                        ");
                Console.WriteLine("====================================\n");
                Console.Write("ENTER YOUR OPTION   ~  ");
                int Option = int.Parse(Console.ReadLine());


                switch (Option)
                {
                    case 1:
                        employees = employeeCRUD.PersonInput();
                        break;

                    case 2:
                        employeeCRUD.Read(employees);
                        break;

                    case 3:
                        employeeCRUD.Update();
                        break;

                    case 4:
                        employeeCRUD.Delete();
                        break;
                }

                if (Option > 4)
                {
                    Console.WriteLine("Invalid Option !");
                    break;
                }

                Console.ReadKey();
            }
        }
    }
}
