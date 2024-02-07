using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Car car = new Car(2001, "Audi");

        //    car.Start();
        //    car.Stop();

        //    AeroPlane plane = new AeroPlane(2018, "Deccan Air");

        //    plane.Start();
        //    plane.TakeOff();
        //    plane.Land();
        //    plane.Stop();
        //}
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t1. ITransport Interface with Car Class");
                Console.WriteLine("\t\t\t2. Book Class");
                Console.WriteLine("\t\t\t3. Shape, Circle, Square");
                Console.WriteLine("\t\t\t4. Calculator");
                Console.WriteLine("\t\t\t5. Vehicle, MotorCycle, Car\n");
                Console.Write("\t\t\tEnter Your Option...  -  ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Carr carr = new Carr();
                        carr.Start();
                        break;

                    case 2:
                        Console.Write("\n\n\t\t\tEnter Book ID  - ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.Write("\t\t\tEnter Author Name  - ");
                        string Author_Name = Console.ReadLine();             //101, "Patnaik Prabhat", "The Value Of Money"
                        Console.Write("\t\t\tEnter Book Title   -");
                        string Title = Console.ReadLine();
                        Book book = new Book(Id, Author_Name, Title);
                        book.Display();
                        break;

                    case 3:
                        Square square = new Square();
                        square.Draw();
                        Circle circle = new Circle();
                        circle.Draw();
                        break;

                    case 4:
                        Console.Write("\n\n\t\t\tEnter Number 1  - ");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2;
                        while (true)
                        {
                            Console.Write("\t\t\tEnter Number 2  - ");
                            num2 = int.Parse(Console.ReadLine());
                            if (num2 != 0)
                                break;
                            Console.WriteLine("\t\tNumber Zero Cannot be Accepted!! Enter Valid Number !");
                        }
                        

                        Calculator calculator = new Calculator();
                        Console.WriteLine("\t\t\tAddition Of Two Numbers       -  " + calculator.Add(num1, num2));
                        Console.WriteLine("\t\t\tSubstraction Of Two Numbers   -  " + calculator.Substract(num1, num2));
                        Console.WriteLine("\t\t\tMultiplication Of Two Numbers -  " + calculator.Multiply(num1, num2));
                        Console.WriteLine("\t\t\tDivision Of Two Numbers       -  " + calculator.Divide(num1, num2));
                        break;
                    case 5:
                        Carr carr1 = new Carr();
                        carr1.StartEngine();

                        MotorCycle cycle = new MotorCycle();
                        cycle.StartEngine();
                        break;
                    default:
                        Console.WriteLine("\n\n\t\t\tInValid Option.....!");
                        break;
                }
                Console.ReadKey();  
            }
            while (option<6);
            
        }
    }
    
}
