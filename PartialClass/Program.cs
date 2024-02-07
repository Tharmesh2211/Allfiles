using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employ employ = new Employ(1, "tharmesh", new DateTime(2002, 11, 22), 10000);
            //employ.Calculate();
            //employ.Display();

            //EmployCRUD.Add(employ);
            //EmployCRUD.Read();
            //while (true)
            //{
            //    string s = Console.ReadLine();
            //    int a = 0, b = 0, c = 0, d = 0;
            //    for (int i = 0; i < s.Length; i++)      //Tharmesh@123          a=1
            //    {

            //        if (isUpper(s[i]))
            //        {
            //            a = 1;
            //        }
            //        else if (isLower(s[i]))
            //        {
            //            b = 1;
            //        }
            //        else if (isDigit(s[i]))
            //        {
            //            c = 1;
            //        }
            //        else
            //            d = 1;
            //    }

            //    if ((a + b + c + d) == 4)
            //    {
            //        Console.WriteLine("Valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Valid");
            //    }
            //    Console.ReadKey();
            //    Console.Clear();
            //}



            int[] arr1 = new int[] { 9, 11, 7, 3, 2 };   // 11   16 
            ////int[] arr2 = new int[arr1.Length];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        if (i == arr1.Length - 1)
            //            break;
            //        int x = arr1[i] + arr1[i + 1] * 9;
            //        int y = arr1[i+1] + arr1[i + 2];
            //        //arr2[i] = x;
            //        //arr2[i + 1] = y;
            //        Console.WriteLine(x +"  "+y+"  ");
            //    }
            //}

            for (int i = 0; i < arr1.Length; i++)  // 9, 11, 7, 3, 2 
            {
                                                    // 11   9   7    3    2
                if (i == arr1.Length - 1)
                        break;
                if (i % 2 == 0)                 // t  =  9      arr1[0] = 11       arr1[1]  = 9(t)
                {
                    int t = arr1[i];
                    arr1[i] = arr1[i + 1];
                    arr1[i + 1] = t;
                }
                else
                {
                    arr1[i] = arr1[i] + arr1[i + 1];
                }

                for (int j = 0; j < arr1.Length; j++)
                {
                    Console.Write(arr1[j] + "  ");
                }
                Console.WriteLine();
            }

        }

        public static bool isUpper(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public static bool isLower(char x)
        {
            return x >= 'a' && x <= 'z';
        }
        public static bool isDigit(char x)
        {
            return x >= '0' && x <= '9';
        }
        public static bool isSpecialChar(char x)
        {
            if (!isUpper(x) && !isLower(x) && !isDigit(x))
            {
                return true;
            }
            return false;
        }

        //public static bool isEmailValid(string s)  //tharmesh12     @gmail.com
        //{
        //    if (!"@gmail.com".Contains(s))
        //        return false;
        //    if (isDigit(s[0]))
        //        return false;
        //    if((!isSpecialChar(s)))

        //}
    }


}
// 1    2     3     4     10

// 0    1     2     3      4

//pos(0+1)  1+2*9 = 19   pos(1+2) = 5
//pos(2+3)  3+4*9 = 39   pos(3+4) = 14





//          input     :   a1b5c10
//          output    : abbbbbcccccccccc
