using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    public class TeacherStudent : ITeacherStudent
    {
        public static TeacherList teacherList = new TeacherList();

        public static StudentList studentList = new StudentList();

        public static List<Teacher> TList = null;

        public static List<Student> SList = null;
        public void Create()
        {
            try
            {
                TList = teacherList.GetTeacherInput();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Read()
        {
            try
            {
                if (teacherList.IsTeacherListNotNull())
                {
                    foreach (var teacher in TList)
                    {
                        int x = 0;
                        teacherList.ReadTeacher(teacher);

                        if (studentList.IsStudentListNotNull())
                        {
                            foreach (var student in SList)
                            {
                                if (student.Teacher_ID.Equals(teacher.Teacher_ID))
                                {
                                    studentList.ReadStudent(student);
                                    x = 1;

                                }

                            }
                            if (x == 0)
                            {
                                Console.WriteLine("No Student For {0} Teacher !", teacher.Teacher_Name);
                            }
                            else
                            {
                                Console.WriteLine("\nThe Teacher {0}'s Student !", teacher.Teacher_Name);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Student List Is Empty !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Teacher List Is Empty !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ReadSpecificRecord()
        {
            try
            {
                if (studentList.IsStudentListNotNull() && teacherList.IsTeacherListNotNull())
                {
                    Console.Write("Enter Teacher ID  :  ");
                    int TeacherID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student Roll Number   :  ");
                    int RollNo = int.Parse(Console.ReadLine());

                    if (studentList.CheckRollNoTearchID(TeacherID, RollNo))
                    {
                        Student storeStudent = studentList.StoreStudent();

                        if (storeStudent.IsDelete.Equals(true))
                        {
                            Console.WriteLine(" Student Roll Number    :  " + storeStudent.Roll_Number);
                            Console.WriteLine(" Student Name           :  " + storeStudent.Student_Name);
                            Console.WriteLine(" Student Date Of Birth  :  " + storeStudent.Student_DOB);
                            Console.WriteLine(" Student Gender         :  " + storeStudent.Student_Gender);
                            Console.WriteLine(" Student Address        :  " + storeStudent.Student_Address);

                        }
                        else
                        {
                            Console.WriteLine("Student Record Not Found !");
                        }
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Update()
        {
            try
            {
                if (studentList.IsStudentListNotNull() && teacherList.IsTeacherListNotNull())
                {
                    Console.Write("Enter Teacher ID  :  ");
                    int TeacherID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student Roll Number   :  ");
                    int RollNo = int.Parse(Console.ReadLine());

                    if (studentList.CheckRollNoTearchID(TeacherID, RollNo))
                    {
                        Student storeStudent = studentList.StoreStudent();

                        if (storeStudent.IsDelete.Equals(true))
                        {
                            Console.Write("Enter New Student Grade  :  ");
                            storeStudent.Student_Grade = char.Parse(Console.ReadLine());

                            Console.WriteLine("Grade Updated Successfully !");
                        }
                        else
                        {
                            Console.WriteLine("Student Record Not Found !");
                        }
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Delete()
        {
            try
            {
                if (studentList.IsStudentListNotNull() && teacherList.IsTeacherListNotNull())
                {
                    Console.Write("Enter Teacher ID  :  ");
                    int TeacherID = int.Parse(Console.ReadLine());

                    Console.Write("Enter Student Roll Number   :  ");
                    int RollNo = int.Parse(Console.ReadLine());

                    if (studentList.CheckRollNoTearchID(TeacherID, RollNo))
                    {
                        Student storeStudent = studentList.StoreStudent();

                        storeStudent.IsDelete = false;

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void AddStudent()
        {
            try
            {
                if (teacherList.IsTeacherListNotNull())
                {
                    Console.Write("Enter Teacher ID  :  ");
                    int TeacherID = int.Parse(Console.ReadLine());

                    if (teacherList.FindTeacherAccount(TeacherID))
                    {
                        SList = studentList.GetStudentInput(TeacherID);
                    }
                    else
                    {
                        Console.WriteLine("\nTeacher ID Not Found !");
                    }

                }
                else
                {
                    Console.WriteLine("List is Empty !");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
