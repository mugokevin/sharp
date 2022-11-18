using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"C:\lesson17\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
