using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MethodOverriding1
    {
        public MethodOverriding1() 
        {
            Console.WriteLine("Executing Method Overriding 1!!");
        }
        public virtual void Hi()
        {
            Console.WriteLine("I'm From Class MethodOverriding 1");
        }
    }

    public class MethodOverriding2 : MethodOverriding1
    {
        public MethodOverriding2()
        {
            Console.WriteLine("Executing Method Overriding 2!!\n");
        }
        public override void Hi()
        {
            base.Hi();
            Console.WriteLine("I'm From Class MethodOverriding 2\n");
        }
    }

    public class MethodOverriding3 : MethodOverriding1
    {
        public MethodOverriding3()
        {
            Console.WriteLine("Executing Method Overriding 3!!\n");
        }
        public override void Hi()
        {
            base.Hi();
            Console.WriteLine("I'm From Class MethodOverriding 3\n");
        }
    }
}
