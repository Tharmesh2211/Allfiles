using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {


        public static void Fibo(int a, int b, int i, int n)
        {
            if (i == 3)//4==3(F)   //5==3(F)  //6==3(F)
                Console.Write(a+" "+b); // 0   1
            if(i<=n) //6<=5(F)
            {
                int c= a + b; // 0+1 = 1   1+1=2       // 1+2=3
                a = b;//  a=1   // a=1   //  a=2
                b = c; // b=1   // b=2   //b=3
                Console.Write(" " + c);
                i++;//4  //5   //6
                Fibo(a, b, i, n);// 1  1  4  5   // 1   2  5  5  // 2  3   6  5
            }
        }

        static void Main(string[] args)
        {
            // int num = 2002;// 1    2     3
            // int cmp = num;
            // int s = 0;
            //while (num!= 0) 
            //{ 
            //     int reminder = num % 10;// 1      2       3   4    5

            //     num = num / 10;// 1234    123    12   1     0

            //     // s = s+reminder;//     s=3+"" s=1    s=2+1  s=21       s=3+21    s=321
            //     s = s * 10 + reminder;    //0*10=0+5   s=5   s=5*10+4  s=54   s=54*10+3   s=543  s=543*10+2 s=5432 s=5432*10+1  s=54321

            //}
            // if (s ==cmp )
            //     Console.WriteLine("valid");
            // else
            //     Console.WriteLine("invalid");


            //    0  1                       1   2  3

            Fibo(0, 1, 3, 15);

        }

    }
}
