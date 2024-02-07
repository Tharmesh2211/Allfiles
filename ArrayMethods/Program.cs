using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8,2,9,7,0,11,23 };
            Array.Sort(nums);                //sorts the array

            foreach (int i in nums)
            {
                Console.Write("\t"+i);
            }
            Console.WriteLine();

            Array.Reverse(nums);             //it reverse the array
            foreach (int i in nums)
            {
                Console.Write("\t"+i); 
            }
            Console.WriteLine();

            Array.Clear(nums, 1, 3);//it clear the values b/w index of 1 to 3 and replace the values by 0
            foreach (int i in nums)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine();


            string[] name =  { "ananth","tharmesh","srisaipriya", "jenifer", "indhu" };
            int index = Array.IndexOf(name, "srisaipriya");  //If the value is present it returns the INDEX
            Console.WriteLine();

            Console.Write("\t"+index);
            Console.WriteLine();

        }
    }
}
