using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the name game");

            Console.Write("what is your first name?");
            string firstName = Console.ReadLine();

            Console.Write("what is your last name?");
            string lastName = Console.ReadLine();

            Console.Write("what city were you born in?");
            string city = Console.ReadLine();

            Console.Write("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);

            Console.ReadLine();

        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}
