using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C\Lesson22\Example.txt");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("there was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("do something....");
            }
            Console.ReadLine();


        }
    }
}
