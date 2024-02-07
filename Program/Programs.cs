using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Programs
    {
        public static void FibonacciWithOutRecursion(int n)
        {
            Console.WriteLine("Fibonacci Series Without Using Recursion!!");
            Console.WriteLine("------------------------------------------");
            int a = 0, b = 1, c;          
            Console.Write(a + " " + b);
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            Console.WriteLine();

        }
        public static void FibonacciWithRecursion(int a, int b, int i, int n)
        {
           
            if (i <= n)// 1<=15(T)
            {
                Console.Write(" " + a);//0
                int c = a + b;//0+1=1
                a = b;//a=1
                b = c;//b=1   
                i++;//2
                FibonacciWithRecursion(a, b, i, n);//1 1 2 15
            }
        }

        public static bool PrimeOrNot(int n)
        {
            Console.WriteLine("\n\nFind a Number " + n + " is Prime Or Not");
            Console.WriteLine("-------------------------------------------------");

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        public static bool PalidromeOrNot(int n)
        {
            Console.WriteLine("\nFind a Number " + n + " is Palindrome or Not!!");
            Console.WriteLine("--------------------------------------------------");

            int s = 0, x = n;
            for (; n != 0; n /= 10)
            {
                s = s * 10 + n % 10;
            }

            if (s == x)            
                return true;

            return false;
        }

        public static int Factorial(int n)
        {
            Console.WriteLine("\nFind Factorial Of  - " + n);
            Console.WriteLine("-------------------------------");

            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        public static bool AmstrongOrNot(int n)
        {
            Console.WriteLine("\nFind " + n + " is Armstrong Or Not!!");
            Console.WriteLine("-----------------------------------------");
            int s = 0, x = n;

            string str = n.ToString();
            int length = str.Length;
            x = n;

            for (; n != 0; n /= 10)  //153  3
            {
                int d = n % 10;
                s = s + (int)Math.Pow(d, length);//27 + 125

            }
            if (s == x)
                return true;
            return false;
        }

        public static int SumOfDigits(int n)
        {
            Console.WriteLine("\nFind Digits Sum for " + n);
            Console.WriteLine("--------------------------");
            int s = 0;
            for (; n != 0; n /= 10)
                s = s + n % 10;
            return s;
        }

        public static int ReverseNumber(int n)
        {
            Console.WriteLine("\nReverse The Number " + n);
            Console.WriteLine("--------------------------");

            int s = 0;
            for (; n != 0; n /= 10)
            {
                s = s * 10 + n % 10;
            }
            return s;
        }

        public static void Alphabet_Pattern(int n)
        {
            Console.WriteLine("\nPrinting Alphabet Pattern!!");
            Console.WriteLine("-------------------------------------------------------");
            int s = 30;
            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= s; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + (char)(j + 64));
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(" " + (char)(k + 64));
                }
                Console.WriteLine();
                s -= 2;
            }
        }

        public static void Number_Triangle(int n)
        {
            Console.WriteLine("\nNumber Triangle!!");
            Console.WriteLine("-----------------------------------------");
            int s = 30;
            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x <= s; x++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + (j));
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(" " + (k));
                }
                Console.WriteLine();
                s -= 2;
            }
        }

        public static void Fibonacci_pattern(int n)
        {
            Console.WriteLine("\nPrinting Fibonacci Series Pattern!!");
            Console.WriteLine("-------------------------------------------------------");
            int[] arr = new int[n];
            arr[0] = 1; arr[1] = 1;
            int i = 2, a = arr[0], b = arr[1];
            while (i < n)
            {
                int c = a + b;
                a = b;
                b = c;
                arr[i] = c;
                i++;
            }
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("  " + arr[j]);
                }
                Console.WriteLine();

            }
        }

        public static void NumberInCharacter(int n)
        {
            Console.WriteLine("\nChange Number " + n + " Into Words!!");
            Console.WriteLine("---------------------------------------------------");
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string s = " ";
            for (; n != 0; n /= 10)
            {
                int reminder = n % 10;
                s = words[reminder] + " " + s;
            }
                Console.WriteLine(s);
            
        }
    }
}



