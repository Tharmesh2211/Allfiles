using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class StudentCRUD
    {

        List<SchoolStudent> students = null;

        SchoolStudent student = null, StoreStudent = null;
        public static int x = 0;
        public StudentCRUD()
        {
            students = new List<SchoolStudent>();
        }
        public List<SchoolStudent> PersonInput()
        {
            try
            {
                Console.Write("Enter Number Of Student Detail to Add  ~  ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Clear();
                    student = new SchoolStudent();

                    student.StudentID += x;

                    Console.Write("Enter Student Name         :  ");
                    student.StudentName = Console.ReadLine();

                    Console.Write("Enter Student DOB          :  ");
                    string[] split = Console.ReadLine().Split('/');
                    student.DOB = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));

                    Console.Write("Enter Student Gender   :  ");
                    student.Gender = Console.ReadLine();

                    Console.Write("Enter Student Standard  :  ");
                    student.Standard = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student PhoneNumber  :  ");
                    student.PhoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter Student Address       :  ");
                    student.Address = Console.ReadLine();

                    Console.Write("Enter Student City         :  ");
                    student.City = Console.ReadLine();

                    x++;

                    Create(student);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return students;

        }

        public void Create(SchoolStudent student)
        {
            try
            {
                students.Add(student);
                Console.WriteLine("Student Record Created Successfully !");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void Read(List<SchoolStudent> students)
        {
            try
            {
                if (Check())
                {
                    Console.Clear();
                    int x = 1;
                    Console.WriteLine("======================================================================================================================");
                    Console.WriteLine($" {"SNO",2} {"ID",3} {"NAME",15}{"DOB",12} {"GENDER",10} {"STANDARD",20} {"PHONENUMBER",15} {"ADDRESS",15} {"CITY",15}   ");
                    Console.WriteLine("======================================================================================================================");
                    foreach (var value in students)
                    {
                        Console.WriteLine($"{x++,2}{value.StudentID,5} {value.StudentName,18} {value.DOB.ToString("dd-MM-yyyy"),13} {value.Gender,10} {value.Standard,4} {value.PhoneNumber,15} {value.Address,15} {value.City,18}");
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
                Console.WriteLine(" 1.  NAME                 ");
                Console.WriteLine(" 2.  DATE OF BIRTH        ");
                Console.WriteLine(" 3.  GENDER               ");
                Console.WriteLine(" 4.  STANDARD             ");
                Console.WriteLine(" 5.  PHONE NUMBER         ");
                Console.WriteLine(" 6.  ADDRESS              ");
                Console.WriteLine(" 7.  CITY                 ");
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
                    Console.Write("Enter Student ID To Update  :  ");
                    int Id = int.Parse(Console.ReadLine());
                    if (Find(Id))
                    {
                        int No = Change();
                        switch (No)
                        {
                            case 1:
                                Console.Write("Enter New Name To Update  -  ");
                                StoreStudent.StudentName = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter New Date Of Birth To Update  -  ");
                                string[] split = Console.ReadLine().Split('/');
                                StoreStudent.DOB = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
                                break;

                            case 3:
                                Console.Write("Enter New Gender To Update  -  ");
                                StoreStudent.Gender = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter New Standard To Update  -  ");
                                StoreStudent.Standard = int.Parse(Console.ReadLine());
                                break;

                            case 5:
                                Console.Write("Enter New Phone Number To Update  -  ");
                                StoreStudent.PhoneNumber = long.Parse(Console.ReadLine());
                                break;
                            case 6:
                                Console.Write("Enter New Address To Update  -  ");
                                StoreStudent.Address = Console.ReadLine();
                                break;

                            case 7:
                                Console.Write("Enter New City Name To Update  -  ");
                                StoreStudent.City = Console.ReadLine();
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
                Console.Write("Enter ID To Delete  The Record  -  ");
                int Id = int.Parse(Console.ReadLine());
                if (Find(Id))
                {
                    students.Remove(StoreStudent);
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
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine($" {"SNO",2} {"ID",3} {"NAME",15}{"DOB",12} {"GENDER",15} {"STANDARD",8} {"PHONENUMBER",15} {"ADDRESS",15} {"CITY",18}   ");
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine($"{x++,2} {StoreStudent.StudentID,5} {StoreStudent.StudentName,20} {StoreStudent.DOB.ToString("dd-MM-yyyy"),12} {StoreStudent.Gender,8} " +
                $"{StoreStudent.Standard,6} {StoreStudent.PhoneNumber,18} {StoreStudent.Address,20} {StoreStudent.City,20}");
        }

        public bool Check()
        {
            if (students != null && students.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool Find(int Id)
        {
            foreach (var value in students)
            {
                if (value.StudentID == Id)
                {
                    StoreStudent = value;
                    return true;
                }
            }
            return false;
        }
    }
}
