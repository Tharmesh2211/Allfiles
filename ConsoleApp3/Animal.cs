﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalss

{
    internal class Dog
    {
        string name = Console.ReadLine();
        string breed = Console.ReadLine();
        string color = Console.ReadLine();
        string age = Console.ReadLine();

        void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        void Play()
        {
            Console.WriteLine(name + " is Playing");
        }
        void sound()
        {
            Console.WriteLine(name + " will make a sound like bow bow");
        }
    }
    internal class Cat {
            string name = Console.ReadLine();
            string breed = Console.ReadLine();
            string color = Console.ReadLine();
            string age = Console.ReadLine();
            bool IsHungry = true;
            void Eat()
            {
                Console.WriteLine(name + " is Eating");
            }
            void sleep()
            {
                Console.WriteLine(name+" is Sleeping");
            }   
            void sound()
            {
                Console.WriteLine(name + " will make a sound like meow meow");
            }
        }
    internal class Tiger {
        string name = Console.ReadLine();
        string breed = Console.ReadLine();
        string color = Console.ReadLine();
        string age = Console.ReadLine();
        
        void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        void sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
        void hunting()
        { 
            Console.WriteLine("At the age of "+age+" "+name+"hunts well");
        }
        void sound()
        {
            Console.WriteLine(name + " ROAR is Powerful ");
        }
    }
    internal class Cow
    {
        string name = Console.ReadLine();
        string breed = Console.ReadLine();
        string color = Console.ReadLine();
        string height = Console.ReadLine();

        void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        void sleep()
        {
            Console.WriteLine(name + " is Sleeping");
        }
       
    }
}
