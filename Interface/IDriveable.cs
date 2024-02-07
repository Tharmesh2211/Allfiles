using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IDriveable
    {
        string Name { get; }
        int Year { get; }
        void Start();
        void Stop();


    }
}
