using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);


            /*l    List<int> list = new List<int>();
             * ist.Add(90);
            list.Add(24);
            list.Add(21);
            list.Add(40);*/
            List<int> list = new List<int>() { 52, 273, 32, 24 };
            list.Remove(52);
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\titem : " + item);

            }

        }
    }
}
