using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "I hope i get a \"great job\" soon";
            //string myString = "i would like a software\n engineering job soon";
            // string myString = "Go to your c:\\ drive";
            // string myString = @"Go to your c:\ drive";

            // string myString = string.Format("{0} = {1}"," soon", "come");

            //string myString = string.Format("{0:C}", 500.86);
            //string myString = string.Format("{0:N}", 5006532563675623786);
            //string myString = string.Format("Percentage:{0:P}", 0.48767);

           // string myString = "cheki ule msee ako na ujinga kama ubwa";
            //myString = myString.Substring(6,20);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ","-------");
            //myString = myString.Remove(6,20);


            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("---");
                myString.Append(i);
            }








            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
