using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.AddDays(5).ToLongDateString());
            Console.WriteLine(now.AddDays(-5).ToLongDateString());
            Console.WriteLine(now.AddHours(5).ToLongTimeString());
            Console.WriteLine(now.AddHours(-5).ToLongTimeString());

            DateTime myBirthday = DateTime.Parse("9/12/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
