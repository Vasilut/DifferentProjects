using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            ICar obj = FactoryBuilder.GetCar("bmw");
            Console.WriteLine(obj.GetSpeed());

            string[] arr = new string[]{ "bmw","audi", "ferrari"};
            foreach (var item in arr)
            {
                ICar objSearched = FactoryBuilder.GetCar(item);
                Console.WriteLine(objSearched.GetSpeed());

            }

            Console.WriteLine("Hello from factory pattern");
            Console.ReadLine();
        }
    }
}
