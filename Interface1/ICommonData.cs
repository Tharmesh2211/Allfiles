using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public interface ICommonData
    {
        string Name { get; }
        int Id { get; }
        int Age { get; }
        DateTime DOB { get; }
        long PhoneNumber {  get; }
        void PrintData();
        void Calculate();
    }

 
}
