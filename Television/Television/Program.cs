using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Transformers", "Michael bay", "PG-13");
            Movie movie2 = new Movie("who am i", "Jackie Chan", "PG");

            Console.WriteLine(movie1.Rating);

            Console.WriteLine(movie2.Rating);

            Console.ReadLine();
        }
    }
}
