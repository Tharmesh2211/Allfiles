using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MotorCycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("MotorCycle Engine has Started!!");
        }
    }
}
