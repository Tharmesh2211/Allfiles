using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Program
    {
        public static void Main(string[] args)
        {
           TeacherStudent Teacherstudent = new TeacherStudent();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tSchool Management");
                Console.WriteLine("\n\t\t1. CREATE            ");
                Console.WriteLine("\n\t\t2. READ              ");
                Console.WriteLine("\n\t\t3. UPDATE            ");
                Console.WriteLine("\n\t\t4. DELETE            ");
                Console.WriteLine("\n\t\t5. Add Student       ");
                Console.WriteLine("\n\t\t6. Read Specific Record ");
                Console.WriteLine("\n\t\t7. EXIT              ");
                Console.Write("\n\n\tEnter Your Option    ");
                int Option = int.Parse(Console.ReadLine());
                                                                                            
                switch (Option)
                {
                    case 1:
                        Teacherstudent.Create();
                        break;

                    case 2:
                        Teacherstudent.Read();
                        break;

                    case 3:
                        Teacherstudent.Update();

                        break;

                    case 4:
                        Teacherstudent.Delete();
                        break;

                    case 5:
                        Teacherstudent.AddStudent();
                        break;

                    case 6:
                        Teacherstudent.ReadSpecificRecord();
                        break;
                }
                Console.ReadKey();
                if (Option == 7)
                    break;
            }       
            

        }
    }
}
