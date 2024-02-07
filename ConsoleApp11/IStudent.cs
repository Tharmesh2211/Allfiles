using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface IStudent
    {
        void CreateStudent();
        void ReadStudent(Student student);
        void UpdateStudent();
        void DeleteStudent();
    }
}
