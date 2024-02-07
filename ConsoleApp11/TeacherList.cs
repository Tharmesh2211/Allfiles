using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class TeacherList : ITeacher
    {
        public static List<Teacher> teacherList = new List<Teacher>();

        public static Teacher teacher = null, StoreTeacherAccount = null;

        public static int TeacherID = 0;

        public List<Teacher> GetTeacherInput()
        {
            try
            {
                char x = ' ';
                do
                {
                    Console.Clear();

                    teacher = new Teacher();

                    Console.Write("Enter Teacher ID     :   "); teacher.Teacher_ID = int.Parse(Console.ReadLine());

                    if (!FindTeacherAccount(teacher.Teacher_ID))
                    {
                        Console.Write("Enter Teacher Name   :   "); teacher.Teacher_Name = Console.ReadLine();

                        CreateTeacher();
                    }
                    else
                    {
                        Console.WriteLine("\nTeacher ID Already Present !");
                    }
                    Console.ReadKey();

                    Console.Clear();

                    Console.Write("\n\tEnter [ Y ] To Add New Teacher Record [ N ] To Skip  >>  ");

                    x = char.Parse(Console.ReadLine().ToUpper());
                    
                    Console.ReadKey();
                }
                while (x != 'N');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return teacherList;
        }

        public void CreateTeacher()
        {
            try
            {
                teacherList.Add(teacher);

                Console.WriteLine("\nTeacher Record Created Successfully !\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ReadTeacher(Teacher teacher)
        {
            Console.WriteLine("Teacher ID           :   {0} ", teacher.Teacher_ID);

            Console.WriteLine("Teacher Name         :   {0} ", teacher.Teacher_Name);
        }


        public bool IsTeacherListNotNull()
        {
            try
            {
                if (!teacherList.Equals(null) && !teacherList.Count.Equals(0))
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public void UpdateTeacher()
        {
           
        }

        public void DeleteTeacher()
        {
          
        }

        public bool FindTeacherAccount(int Teacher_ID)
        {
            foreach (var teacher in teacherList)
            {
                if (teacher.Teacher_ID.Equals(Teacher_ID))
                {
                    TeacherID = teacher.Teacher_ID;

                    StoreTeacherAccount = teacher;

                    return true;
                }
            }
            return false;
        }

        public int GetTeacher_ID()
        {
            return TeacherID;
        }
    }
}
