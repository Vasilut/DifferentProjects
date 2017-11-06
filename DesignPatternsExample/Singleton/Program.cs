using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //not safe
            var singletonNotSafe = SingletonNotSafe.Instance;
            singletonNotSafe.SayHelloToSingleton();

            ////safe
            //var singletonSafe = SingletonSafe.Instance;
            //singletonSafe.SayHelloToSingleton();

            ////safe and eficient
            //var singletonEficient = SingletonSafeAndPerformant.Instance;
            //singletonEficient.SayHelloToSingleton();


            Console.WriteLine("Hello from singleton pattern");
            Console.ReadLine();
        }
    }
}
