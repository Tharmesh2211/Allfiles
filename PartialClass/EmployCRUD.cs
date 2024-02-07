using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public static class EmployCRUD
    {
        public static List<Employ> employs = null;

        public static void Add(Employ employ)
        {
            if (employs == null)
            {
                employs = new List<Employ>();
            }
            employs.Add(employ);
        }

        public static void Read()
        {
            if(employs != null)
            {
                foreach(Employ employ in employs)
                {
                    Console.WriteLine(employ.Emp_ID+"     "+employ.Emp_Name);
                }
            }
        }
    }
}
