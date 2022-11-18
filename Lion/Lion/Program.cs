using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("JK Rowling", "Harry potter", 400);
           
            Book book2 = new Book("Tolkein", "Lord of the rings", 700);
           

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }

    }
}
