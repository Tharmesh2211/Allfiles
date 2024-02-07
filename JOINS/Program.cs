using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOINS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for(; ; )
            {
                Console.Clear();

                try
                {
                    LOGIN lOGIN = new LOGIN();
                    Console.WriteLine("- - - - - - - - - - - - - - - - ");
                    Console.WriteLine("      CRUD WITH LINQ            ");
                    Console.WriteLine("- - - - - - - - - - - - - - - - ");
                    Console.WriteLine("  1.  ADD                       ");
                    Console.WriteLine("  2.  READ                      ");
                    Console.WriteLine("  3.  FIND                      ");
                    Console.WriteLine("  4.  UPDATE                    ");
                    Console.WriteLine("  5.  DELETE                    ");
                    Console.WriteLine("- - - - - - - - - - - - - - - - ");
                    Console.Write("Enter Your Option   -  ");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            lOGIN.Add();
                            break;

                        case 2:
                            lOGIN.Read();
                            break;

                        case 3:
                            Console.WriteLine(lOGIN.IsValid() ?
                                "VALID USER NAME & PASSWORD" : "NOT VALID USER NAME & PASSWORD");
                            Console.ReadKey();
                            break;

                        case 4:
                            lOGIN.Update();
                            break;

                        case 5:
                            lOGIN.Delete();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
