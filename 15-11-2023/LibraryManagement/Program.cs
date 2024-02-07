using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibraryCRUD libraryCRUD = new LibraryCRUD();
                List<Library> libraries = null;
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
                        libraries = libraryCRUD.PersonInput();
                            break;

                        case 2:
                        libraryCRUD.Read(libraries);
                            break;

                        case 3:
                        libraryCRUD.Update();
                            break;

                        case 4:
                        libraryCRUD.Delete();
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
