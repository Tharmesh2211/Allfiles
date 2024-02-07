using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "hello", "World", "Java", "Python", "C#", "c++" };
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("--------------------------");
            int[] num = { 1, 2, 3, 5, 8,12,98 };
            foreach (int nums in num)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine("--------------------------");
        }
    }
}
