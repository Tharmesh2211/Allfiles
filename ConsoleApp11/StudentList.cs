using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class StudentList : IStudent
    {
        public static List<Student> studentList = new List<Student>();

        public static Student StoreStudentAccount = null;

        public static Student student = null;

        public List<Student> GetStudentInput(int teacher_id)
        {
            try
            {
                char x = ' ';

                int c = 0;

                while (true)
                {
                    Console.Clear();

                    student = new Student();

                    student.Roll_Number += c;

                    Console.Write("Enter Student Name          :  "); student.Student_Name = Console.ReadLine();

                    //Console.Write("Enter Student Date Of Birth :  ");

                    //string DOB = Console.ReadLine();

                    //string[] SplitDOB = DOB.Split('/');

                    //student.Student_DOB = new DateTime(int.Parse(SplitDOB[2]), int.Parse(SplitDOB[1]), int.Parse(SplitDOB[0]));

                    //Console.Write("Enter Student Gender       :  "); student.Student_Gender = Console.ReadLine();

                    //Console.Write("Enter Student Address      :  "); student.Student_Address = Console.ReadLine();

                    Console.Write("Enter Student Grade        :  "); student.Student_Grade = char.Parse(Console.ReadLine());

                    student.Teacher_ID = teacher_id;

                    CreateStudent();

                    Console.WriteLine("\n\tDo You Want To Add Another Student For A Same Teacher [ Y ] OR [ N ]   >>  ");

                    x = char.Parse(Console.ReadLine().ToUpper());

                    c++;

                    if (x == 'N')
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return studentList;
        }
        public void CreateStudent()
        {
            try
            {
                studentList.Add(student);

                Console.WriteLine("\nStudent Record Created Successfully !\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ReadStudent(Student student)
        {

            Console.Write("Student Roll Number      :   {0} ", student.Roll_Number);

            Console.Write("Student  Name            :   {0} ", student.Student_Name);

            Console.WriteLine("Student  Grade       :   {0} ", student.Student_Grade);

        }
        public void UpdateStudent()
        {
        }
        public void DeleteStudent()
        {

        }

        public bool IsStudentListNotNull()
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

        public bool FindStudentAccount(int RollNo)
        {
            foreach (var value in studentList)
            {
                if (value.Roll_Number.Equals(RollNo) && value.IsDelete.Equals(true))
                {
                    StoreStudentAccount = value;
                    return true;
                }
            }
            return false;
        }

        public Student StoreStudent()
        {
            return StoreStudentAccount;
        }

        public bool CheckRollNoTearchID(int TeacherID, int RollNo)
        {
            foreach (var student in studentList)
            {
                if (student.Teacher_ID.Equals(TeacherID) && student.Roll_Number.Equals(RollNo))
                {
                    StoreStudentAccount = student;
                    return true;
                }
            }
            return false;
        }
    }
}
