using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MethodOverloading
    {
        public int Add(int x, int y)
        {
            return x+ y;
        }
        public float Add(int x, float y)
        {
            return x + y;
        }
        public string Add(int x, string y, float z) 
        {
            return x + y + z;
        }
        public long Add(long x, long y) 
        {
            return x + y;
        }
    }
}
