using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "THarmesh";
            Console.WriteLine("String Length : "+name.Length);
            Console.WriteLine("String UPPERT : " + name.ToUpper());
            Console.WriteLine("String LOWER : " + name.ToLower());
            Console.WriteLine("String Replace : " + name.Replace("TH","HI"));//(old str, new str)
            Console.WriteLine("String  Compare : " + name.CompareTo("tharmesh"));// check each string char ASCII If s1>s2 1 || s1<s2 -1 ||s1==s2 0
            Console.WriteLine("String Concat : " + string.Concat(name,"Waran"));
            Console.WriteLine("String Contains : " + name.Contains("THa"));//check 2nd string present in 1st string or not
            Console.WriteLine("String EndWith : " + name.EndsWith("Mesh"));//check 2ns string endwith in 1st string or not
            Console.WriteLine("String StartWith : " + name.StartsWith("THar"));//check 2ns string Startwith in 1st string or not
            Console.WriteLine("String Equals : " +name.Equals("tharmesh"));//check both string = or !
            Console.WriteLine("String IndexOF : "+name.IndexOf('e'));//return char index
            Console.WriteLine("String Remove : "+name.Remove(1,3));
        }
    }
}
