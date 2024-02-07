using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class LibraryCRUD
    {
            List<Library> libraries = null;

        Library library = null, StoreLibraryAcc = null;
          
            public LibraryCRUD()
            {
            libraries = new List<Library>();
            }
            public List<Library> PersonInput()
            {
                try
                {
                    Console.Write("Enter Number Of Student Detail to Add  ~  ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        Console.Clear();
                    library = new Library();

                    Console.Write("Enter Book ID   :  ");
                    library.BookID = int.Parse(Console.ReadLine());

                        Console.Write("Enter Customer Name         :  ");
                    library.CustomerName = Console.ReadLine();

                    Console.Write("Enter Book Name         :  ");
                    library.BookName = Console.ReadLine();

                    Console.Write("Enter Book Title       :  ");
                    library.Title = Console.ReadLine();


                    Console.Write("Enter  CheckIn Date          :  ");
                        string[] split = Console.ReadLine().Split('/');
                    library.CheckIn = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));

                    Console.Write("Enter  CheckOut Date          :  ");
                    split = Console.ReadLine().Split('/');
                    library.CheckOut = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));

                        Create(library);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return libraries;

            }

            public void Create(Library library)
            {
                try
                {
                libraries.Add(library);
                    Console.WriteLine("Book Record Created Successfully !");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            public void Read(List<Library> employees)
            {
                try
                {
                    if (Check())
                    {
                        Console.Clear();
                        int x = 1;
                       foreach (var value in employees)
                        {
                        Console.Clear();
                        Console.WriteLine("Customer Name   :  "+value.CustomerName);
                        Console.WriteLine("Book ID         :  "+value.BookID);
                        Console.WriteLine("Book Name       :  "+value.BookName);
                        Console.WriteLine("Book Title      :  "+value.Title);
                        Console.WriteLine("CheckIn Date    :  " + value.CheckIn);
                        Console.WriteLine("CheckOut Date    :  " + value.CheckOut);
                        Console.ReadKey();
                    }
                    }
                    else
                    {
                        Console.WriteLine("List Is Empty !");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public int Change()
            {
                try
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("        UPDATE            ");
                    Console.WriteLine("==========================");
                    Console.WriteLine(" 1.  CUSTOMER NAME        ");
                    Console.WriteLine(" 2.  BOOK NAME            ");
                    Console.WriteLine(" 3.  BOOK TITLE           ");
                    Console.WriteLine(" 4.  CHECKIN DATE         ");
                    Console.WriteLine(" 5.  CHECKOUT DATE        ");
                    Console.WriteLine("==========================\n");
                    Console.Write("Enter Your Option  ~  ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return int.Parse(Console.ReadLine());

            }
            public void Update()
            {
                Console.Clear();
                try
                {
                    if (Check())
                    {
                        Console.Write("Enter Book ID To Update  :  ");
                        int Id = int.Parse(Console.ReadLine());
                        if (Find(Id))
                        {
                            int No = Change();
                            switch (No)
                            {
                                case 1:
                                    Console.Write("Enter New Customer Name To Update  -  ");
                                StoreLibraryAcc.CustomerName = Console.ReadLine();
                                    break;

                                case 2:
                                Console.Write("Enter New Book Name To Update  -  ");
                                StoreLibraryAcc.BookName = Console.ReadLine();
                                break;
                                
                            case 3:
                                Console.Write("Enter New Book Title To Update  -  ");
                                StoreLibraryAcc.Title = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter New CheckIn Date To Update  -  ");
                                string[] split = Console.ReadLine().Split('/');
                                StoreLibraryAcc.CheckIn = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
                                break;

                            case 5:
                                Console.Write("Enter New CheckOut Date To Update  -  ");
                                 split = Console.ReadLine().Split('/');
                                StoreLibraryAcc.CheckOut = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
                                break;

                            default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                            ReadOnlyOne();
                        }
                        else
                        {
                            Console.WriteLine("No ID Found !");
                        }

                    }
                    else
                    {
                        Console.WriteLine("List Is Empty !");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            public void Delete()
            {
                if (Check())
                {
                    Console.Write("Enter Book ID To Delete  The Record  -  ");
                    int Id = int.Parse(Console.ReadLine());
                    if (Find(Id))
                    {
                    libraries.Remove(StoreLibraryAcc);
                        Console.WriteLine("Record Deleted Successfully !");
                    }
                    else
                    {
                        Console.WriteLine("No ID Found !");
                    }
                }
                else
                {
                    Console.WriteLine("List Is Empty !");
                }

            }

            public void ReadOnlyOne()
            {
            Console.WriteLine("Customer Name   :  " + StoreLibraryAcc.CustomerName);
            Console.WriteLine("Book ID         :  " + StoreLibraryAcc.BookID);
            Console.WriteLine("Book Name       :  " + StoreLibraryAcc.BookName);
            Console.WriteLine("Book Title      :  " + StoreLibraryAcc.Title);
            Console.WriteLine("CheckIn Date    :  " + StoreLibraryAcc.CheckIn);
            Console.WriteLine("CheckOut Date    :  " + StoreLibraryAcc.CheckOut);
        }

            public bool Check()
            {
                if (libraries != null && libraries.Count != 0)
                {
                    return true;
                }
                return false;
            }

            public bool Find(int Id)
            {
                foreach (var value in libraries)
                {
                    if (value.BookID == Id)
                    {
                    StoreLibraryAcc = value;
                        return true;
                    }
                }
                return false;
            }
        }
    }