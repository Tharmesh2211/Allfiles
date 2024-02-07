using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TeacherList teacher = new TeacherList();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tSchool Management");
                Console.WriteLine("\n\t\t1. CREATE            ");
                Console.WriteLine("\n\t\t2. READ              ");
                Console.WriteLine("\n\t\t3. UPDATE            ");
                Console.WriteLine("\n\t\t4. DELETE            ");
                Console.WriteLine("\n\t\t5. EXIT              ");
                Console.Write("\n\n\tEnter Your Option    ");
                int Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1: teacher.GetTeacherInput();
                        break;

                    case 2: teacher.Read();
                        break;

                    case 3: teacher.Update();

                        break;

                    case 4: teacher.Delete();
                        break;

                }
                Console.ReadKey();
                if (Option == 5)
                    break;
            }       
            

        }
    }
}
