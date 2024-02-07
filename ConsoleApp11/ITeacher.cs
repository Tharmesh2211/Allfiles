using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public interface ITeacher
    {
        void CreateTeacher();
        void ReadTeacher(Teacher teacher);
        void UpdateTeacher();
        void DeleteTeacher();

    }
}
