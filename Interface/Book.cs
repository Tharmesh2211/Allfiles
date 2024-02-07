using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Book
    {
        public int Id { get; set; }
        public string Author_Name { get; set; }
        public string Title { get; set; }
        public Book(int Id, string Author_Name, string Title)
        {
            this.Id = Id;
            this.Author_Name = Author_Name; 
            this.Title = Title;
        }
        public void Display()
        {
            Console.WriteLine("Book ID     : " + Id);
            Console.WriteLine("Author Name : "+Author_Name);
            Console.WriteLine("Book Title  : "+Title);
        }

    }
}
