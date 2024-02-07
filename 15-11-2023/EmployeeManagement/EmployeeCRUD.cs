using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeCRUD
    {

        List<Employee> employees = null;

        Employee employee = null, StoreEmployee = null;
        public static int x = 0;
        public EmployeeCRUD()
        {
            employees = new List<Employee>();
        }
        public List<Employee> PersonInput()
        {
            try
            {
                Console.Write("Enter Number Of Employee Detail to Add  ~  ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.Clear();
                    employee = new Employee();

                    employee.EmployeetID += x;

                    Console.Write("Enter Employee Name         :  ");
                    employee.EmployeeName = Console.ReadLine();

                    Console.Write("Enter Employee DOB          :  ");
                    string[] split = Console.ReadLine().Split('/');
                    employee.DOB = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));

                    Console.Write("Enter Employee Gender   :  ");
                    employee.Gender = Console.ReadLine();

                    Console.Write("Enter Employee PhoneNumber  :  ");
                    employee.PhoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter Employee Address       :  ");
                    employee.Address = Console.ReadLine();

                    Console.Write("Enter Employee City         :  ");
                    employee.City = Console.ReadLine();

                    Console.Write("Enter Employee Salary  :  ");
                    employee.Salary = double.Parse(Console.ReadLine());

                    x++;

                    Create(employee);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employees;

        }

        public void Create(Employee employee)
        {
            try
            {
                employees.Add(employee);
                Console.WriteLine("Employee Record Created Successfully !");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void Read(List<Employee> employees)
        {
            try
            {
                if (Check())
                {
                    Console.Clear();
                    int x = 1;
                    Console.WriteLine("======================================================================================================================");
                    Console.WriteLine($" {"SNO",2} {"ID",3} {"NAME",15}{"DOB",12} {"GENDER",10} {"SALARY",20} {"PHONENUMBER",15} {"ADDRESS",15} {"CITY",15}   ");
                    Console.WriteLine("======================================================================================================================");
                    foreach (var value in employees)
                    {
                        Console.WriteLine($"{x++,2}{value.EmployeetID,5} {value.EmployeeName,18} {value.DOB.ToString("dd-MM-yyyy"),13} {value.Gender,10} {value.Salary,4} {value.PhoneNumber,15} {value.Address,15} {value.City,18}");
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
                Console.WriteLine(" 4.  SALARY               ");
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
                    Console.Write("Enter Employee ID To Update  :  ");
                    int Id = int.Parse(Console.ReadLine());
                    if (Find(Id))
                    {
                        int No = Change();
                        switch (No)
                        {
                            case 1:
                                Console.Write("Enter New Name To Update  -  ");
                                StoreEmployee.EmployeeName = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter New Date Of Birth To Update  -  ");
                                string[] split = Console.ReadLine().Split('/');
                                StoreEmployee.DOB = new DateTime(int.Parse(split[2]), int.Parse(split[1]), int.Parse(split[0]));
                                break;

                            case 3:
                                Console.Write("Enter New Gender To Update  -  ");
                                StoreEmployee.Gender = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter New Salary To Update  -  ");
                                StoreEmployee.Salary = double.Parse(Console.ReadLine());
                                break;

                            case 5:
                                Console.Write("Enter New Phone Number To Update  -  ");
                                StoreEmployee.PhoneNumber = long.Parse(Console.ReadLine());
                                break;
                            case 6:
                                Console.Write("Enter New Address To Update  -  ");
                                StoreEmployee.Address = Console.ReadLine();
                                break;

                            case 7:
                                Console.Write("Enter New City Name To Update  -  ");
                                StoreEmployee.City = Console.ReadLine();
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
                    employees.Remove(StoreEmployee);
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
            Console.WriteLine($" {"SNO",2} {"ID",3} {"NAME",15}{"DOB",12} {"GENDER",15} {"SALARY",8} {"PHONENUMBER",15} {"ADDRESS",15} {"CITY",18}   ");
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine($"{x++,2} {StoreEmployee.EmployeetID,5} {StoreEmployee.EmployeeName,20} {StoreEmployee.DOB.ToString("dd-MM-yyyy"),12} {StoreEmployee.Gender,8} " +
                $"{StoreEmployee.Salary,6} {StoreEmployee.PhoneNumber,18} {StoreEmployee.Address,20} {StoreEmployee.City,20}");
        }

        public bool Check()
        {
            if (employees != null && employees.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool Find(int Id)
        {
            foreach (var value in employees)
            {
                if (value.EmployeetID == Id)
                {
                    StoreEmployee = value;
                    return true;
                }
            }
            return false;
        }
    }
}
