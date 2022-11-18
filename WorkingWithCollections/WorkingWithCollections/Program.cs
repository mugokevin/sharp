using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1=new Car();
            car1.Make = "Toyota";
            car1.Model = "Hiace";
            car1.VIN = "AI";

            Car car2=new Car();
            car2.Make = "Nissan";
            car2.Model = "Dualis";
            car2.VIN = "t2";

            Book b1=new Book();
            b1.Title = "Harry potter";
            b1.Author = "J.K Rowling";
            b1.ISBN = "0-00000-000";

            //Arraylist
            
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            

            // List<T>
            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            

            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["t2"].Make);
            
            //object initializer syntax
            Car car1 = new Car() { Make= "Toyota", Model = "Probox", VIN = "C3"};
            Car car2 = new Car() { Make= "Nissan", Model = "NV200", VIN = "A4"};
            Car car3 = new Car() { Make= "Mitsubishi", Model = "FH", VIN = "P60"};
            */

            //collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car {Make= "Toyota", Model = "Probox", VIN = "C3"},
                new Car { Make= "Mitsubishi", Model = "FH", VIN = "P60"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
