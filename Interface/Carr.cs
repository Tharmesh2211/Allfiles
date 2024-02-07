using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface
{
    public class Carr: Vehicle,ITransport
    {
        public void Start()
        {
            Console.WriteLine(" Your Car is Starting "+(char)(3));
        }
        public override void StartEngine()
        {
            Console.WriteLine("Your Car Engine has Started!!");
        }
    }
}
