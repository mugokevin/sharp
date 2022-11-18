using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("kevin", "engineering", 88);
            Student student2 = new Student("laban", "Englitt", 64);
            Student student3 = new Student("joe", "Econstat", 72);
            Student student4 = new Student("gloria", "cdev", 80);
            Student student5 = new Student("wayne", "psychology", 60);
            Student student6 = new Student("awilo", "Econsoci", 78);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
            Console.WriteLine(student3.HasHonours());
            Console.WriteLine(student4.HasHonours());
            Console.WriteLine(student5.HasHonours());
            Console.WriteLine(student6.HasHonours());



            Console.ReadLine();
        }
    }
}
