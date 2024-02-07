using System;

namespace Program
{
    public class Program
    {   
        static void Main(string[] args)
        {
            Programs.FibonacciWithOutRecursion(15);
            Console.ReadKey();

            Console.WriteLine("\nFibonacci Series With Using Recursion!!");
            Console.WriteLine("------------------------------------------");
            Programs.FibonacciWithRecursion(0,1,1,15);
            Console.ReadKey();

            bool PrimeorNot = Programs.PrimeOrNot(11);
            if(PrimeorNot)
            {
                Console.WriteLine("It is Prime Number!!");
            }
            else
            {
                Console.WriteLine("It is Not A Prime Number!!");
            }
            Console.ReadKey();

            bool PalindromeOrNot = Programs.PalidromeOrNot(123);
            if(PalindromeOrNot)
            {
                Console.WriteLine("Given Number is Palindrome!!");
            }
            else
            {
                Console.WriteLine("Given Number is Not Palindrome!!");
            }
            Console.ReadKey();

            Console.WriteLine("The Factorial is : "+ Programs.Factorial(6));
            Console.ReadKey();

            bool AmstrongorNot = Programs.AmstrongOrNot(371);
            if (AmstrongorNot)
            {
                Console.WriteLine("The Given Number is Armstrong!!");
            }
            else
            {
                Console.WriteLine("The Given Number is Not Armstrong!!");
            }
            Console.ReadKey();

            Console.WriteLine("The Sum Of Digits is : " + Programs.SumOfDigits(12345));
            Console.ReadKey();

            Console.WriteLine("After Reversing the Number is : " + Programs.ReverseNumber(234));
            Console.ReadKey();

            Programs.Alphabet_Pattern(5);
            Console.ReadKey();

            Programs.Number_Triangle(5);
            Console.ReadKey();

            Programs.Fibonacci_pattern(9);
            Console.ReadKey();

            Programs.NumberInCharacter(479463);
            Console.ReadKey();

        }
    }
}

            