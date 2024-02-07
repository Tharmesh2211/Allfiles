using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class ManageStudent
    {
        public List<Student> Create()
        {
            List<Student> list = new List<Student>()
            {
                new Student() {Id = 1, Name = "kiran", Age = 23, IsDeleted = true},
                new Student() {Id = 2, Name = "sam", Age = 21, IsDeleted = true},
                new Student() {Id = 3, Name = "jeeva", Age = 15, IsDeleted = true}
            };
            return list;
        }

        public void Read(List<Student> students)
        {
            foreach (var student in students)
            {
                if(student.IsDeleted == true)
                Console.WriteLine(student.Id +"   "+ student.Name +"   "+student.Age);
            }
        }

        public void Update(List<Student> students)
        {
            Console.Write("Enter Student ID   :  ");
            int SID = int.Parse(Console.ReadLine());
            bool ischeck = false;
            foreach (var student in students)
            {
                if(student.Id == SID)
                {
                    Console.Write("Enter New Student Name  :  ");
                    string name = Console.ReadLine();

                    student.Name = name;
                    ischeck = true;
                    break;
                }
            }

            if(ischeck)
            {
                Console.WriteLine("Student Present!");
            }
            else
            {
                Console.WriteLine("Student Not Present!");
            }
        }

        public void Delete(List<Student> students)
        {
            Console.Write("Enter Student ID To Delete  :  ");
            int SID = int.Parse(Console.ReadLine());
            foreach (var student in students)
            {
                if (student.Id == SID)
                {
                    student.IsDeleted = false;
                }
            }
        }
    }
}
