using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
     internal class Tamil
    {
        static string mark = "90";
        static void Study()
        {
            Console.WriteLine("Studying Tamil");
        }
        static void DisplayMark()
        {
            Console.Write("Your mark in tamil is "+mark);
        }

    }

    internal class English
    {
        static string mark = "100";

        static void Study()
        {
            Console.WriteLine("Studying English");
        }
        static void DisplayMark()
        {
            Console.Write("Your mark in English is " + mark);
        }
    }

    internal class Hindi
    {
        static string mark = "59";

        static void Study()
        {
            Console.WriteLine("Studying Hindi");
        }
        static void DisplayMark()
        {
            Console.Write("Your mark in Hindi is " + mark);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
    }
}
