using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.AddInput();
            person.Display();
            Console.WriteLine("====================");
            person.Remove();
            Console.WriteLine("====================");
            person.Display();
            Console.WriteLine("====================");
            person.Display1();
            Console.WriteLine("====================");
        }

        public class Person
        {
          List<Person> list = new List<Person>();
            Person person = null, person1 = null;
            public int Id { get; set; }
            public string Name { get; set; }
            public bool check { get; set; }

            public void AddInput()
            {
                
                for(int i = 0;i<2;) 
                {
                    person = new Person();
                    Console.Write("Enter ID   : ");
                    person.Id = int.Parse(Console.ReadLine());
                    
                        if(Find(person.Id))
                        {
                            Console.WriteLine("ID Already Exist . Enter New ID !!");
                            continue;
                        }
                    

                    Console.Write("Enter Name  :");
                    person.Name = Console.ReadLine();

                    person.check = true;
                    Create(person);
                    i++;
                }
               
                
            }
            public void Create(Person person)
            {

                list.Add(person);
            }

            public void Display()
            {
                foreach (var item in list)
                {
                    if(item.check)
                    Console.WriteLine(item.Id);
                }
            }
            public void Remove()
            {
                int Id = 2;
                foreach(var item in list)
                {
                    if (item.Id == Id)
                        item.check = false;
                }

            }
            public void Display1()
            {
                foreach (var item in list)
                {
                   
                        Console.WriteLine(item.Id +"    "+item.check);
                }
            }
            public bool IsCount()
            {
                if(list!=null && list.Count > 0)
                    return true;
                return false;
            }

            public bool Find(int Id)
            {
                foreach(var item in list)
                {
                    if(item.Id == Id)
                        return true;
                }
                return false;
            }
        }
    }
}
