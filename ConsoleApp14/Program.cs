using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManageStudent student = new ManageStudent();

            List<Student> list = student.Create();

            student.Read(list);

            student.Update(list);

            student.Read(list);

            student.Delete(list);

            student.Read(list);

        }
    }
}
