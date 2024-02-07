using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
     class Program
     {
        public static void Main(string[] args)
        {
           
                StudentCRUD studentCRUD = new StudentCRUD();
                List<SchoolStudent> students = null;
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
                        students = studentCRUD.PersonInput();
                            break;

                        case 2:
                        studentCRUD.Read(students);
                            break;

                        case 3:
                        studentCRUD.Update();
                            break;

                        case 4:
                        studentCRUD.Delete();
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