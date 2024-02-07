using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public class TeacherList
    {
        public static List<Teacher> teacherList = new List<Teacher>();

        public static List<Student> studentList = new List<Student>();

        public static Student StoreStudentAccount = null;
        public void GetTeacherInput()
        {
            try
            {
                char x = ' ';
                do
                {
                    Console.Clear();
                    Teacher teacher = new Teacher();

                    Console.Write("Enter Teacher ID     :   "); teacher.Teacher_ID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Teacher Name   :   "); teacher.Teacher_Name = Console.ReadLine();

                    CreateTeacher(teacher);

                    GetStudentInput(teacher);

                    Console.Clear();

                    Console.Write("\n\tEnter [ Y ] To Add New Teacher Record [ N ] To Skip  >>  ");

                    x = char.Parse(Console.ReadLine().ToUpper());

                }
                while (x != 'N');
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void GetStudentInput(Teacher teacher)
        {
            try
            {
                char x = ' ';
                do
                {
                    Student student = new Student();

                    Console.Write("Enter Student Roll Number   :  "); student.Roll_Number = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student Name          :  "); student.Student_Name = Console.ReadLine();

                    Console.Write("Enter Student Date Of Birth :  ");

                    string DOB = Console.ReadLine();

                    string[] SplitDOB = DOB.Split('/');

                    student.Student_DOB = new DateTime(int.Parse(SplitDOB[2]), int.Parse(SplitDOB[1]), int.Parse(SplitDOB[0]));

                    Console.Write("Enter Student Gender       :  "); student.Student_Gender = Console.ReadLine();

                    Console.Write("Enter Student Address      :  "); student.Student_Address = Console.ReadLine();

                    Console.Write("Enter Student Grade        :  "); student.Student_Grade = char.Parse(Console.ReadLine());

                    student.Teacher_ID = teacher.Teacher_ID;

                    CreateStudent(student);

                    Console.Write("\n\tEnter [ Y ] To Add New Student Record [ N ] To Skip  >>  "); 
                    
                    x = char.Parse(Console.ReadLine().ToUpper());

                }
                while (x != 'N');
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void CreateTeacher(Teacher teacher )
        {
            try
            {
                teacherList.Add(teacher);
                Console.WriteLine("\nTeacher Record Created Successfully !\n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CreateStudent(Student student)
        {
            try
            {
                studentList.Add(student); 
                Console.WriteLine("\nStudent Record Created Successfully !\n");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ReadTeacher()
        {
            Console.Clear();
            try
            {
                if (IsTeacherListNull() && IsStudentListNull())
                {
                    foreach (var teacher in teacherList)
                    {
                        int x = 1;

                        bool Change = true;

                        foreach (var student in studentList)
                        {
                            if (teacher.Teacher_ID.Equals(student.Teacher_ID) && student.IsDelete.Equals(true))
                            {

                                if (Change)
                                {
                                    Console.WriteLine("Teacher ID           :   {0} " , teacher.Teacher_ID);

                                    Console.WriteLine("Teacher Name         :   {0} " , teacher.Teacher_Name);

                                    Change = false;
                                }

                                Console.Write("Student {0} Roll Number      :   {1} ", x++, student.Roll_Number);

                                Console.Write("    Student  Name            :   {0} " , student.Student_Name);

                                Console.WriteLine("    Student  Grade       :   {0} " , student.Student_Grade);
                            } 
                        }

                        Console.WriteLine("\nThe Teacher {0} Has {1} Numbers Of Student !", teacher.Teacher_Name, x - 1);
                        
                        Console.ReadKey();

                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("List Is Empty !");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public bool IsTeacherListNull()
        {
            try
            {
                if (!teacherList.Equals(null) && !teacherList.Count.Equals(0))
                    return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public bool IsStudentListNull()
        {
            try
            {
                if (!studentList.Equals(null) && !studentList.Count.Equals(0))
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public void ReadSpecificDetail()
        {
            if(IsStudentListNull() && IsTeacherListNull())
            {
                Console.Write("Enter Student Roll Number   :  ");
                int RollNo = int.Parse(Console.ReadLine());

                if(FindAccount(RollNo) && StoreStudentAccount.IsDelete.Equals(true))
                {
                    Console.WriteLine(" Student Roll Number    :  "+StoreStudentAccount.Roll_Number);
                    Console.WriteLine(" Student Name           :  "+StoreStudentAccount.Student_Name);
                    Console.WriteLine(" Student Date Of Birth  :  "+StoreStudentAccount.Student_DOB);
                    Console.WriteLine(" Student Gender         :  "+StoreStudentAccount.Student_Gender);
                    Console.WriteLine(" Student Address        :  "+StoreStudentAccount.Student_Address);
                }
                else
                {
                    Console.WriteLine("Student Record Not Found !");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty !");
            }
        }

        public bool FindAccount(int RollNo)
        {
            foreach(var value in studentList)
            {
                if(value.Roll_Number.Equals(RollNo) && value.IsDelete.Equals(true))
                {
                    StoreStudentAccount = value;
                    return true;

                }
            }
            return false;
        }

        public void UpdateTeacher()
        {
            if (IsStudentListNull() && IsTeacherListNull())
            {
                Console.Write("Enter Student Roll Number   :  ");
                int RollNo = int.Parse(Console.ReadLine());

                if (FindAccount(RollNo) && StoreStudentAccount.IsDelete.Equals(true))
                {
                    Console.Write("Enter New Student Grade  :  "); StoreStudentAccount.Student_Grade = char.Parse(Console.ReadLine());
                    Console.WriteLine("Grade Updated Successfully !");
                }
                else
                {
                    Console.WriteLine("Student Record Not Found !");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty !");
            }
        }

        public void DeleteTeacher()
        {
            if (IsStudentListNull() && IsTeacherListNull())
            {
                Console.Write("Enter Student Roll Number   :  ");
                int RollNo = int.Parse(Console.ReadLine());

                if (FindAccount(RollNo))
                {
                    StoreStudentAccount.IsDelete = false;
                    Console.WriteLine("Student Record Deleted Successfully !");
                }
                else
                {
                    Console.WriteLine("Student Record Not Found !");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty !");
            }
        }
    }
}
