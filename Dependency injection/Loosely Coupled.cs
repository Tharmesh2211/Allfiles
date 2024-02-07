using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    public class Loosely_Coupled
    {
        private readonly IAbout iAbout;

        public Loosely_Coupled(IAbout iAbout)
        {
            this.iAbout = iAbout;
        }

        public void Call()
        {
            iAbout.Assign();
            iAbout.Print();
        }
      
    }
}
