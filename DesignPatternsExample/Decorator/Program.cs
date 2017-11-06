using System;

namespace Decorator
{
    /*
     *Let's say that we're building a showroom with cars. 
     * We have some categories: Economy and Luxury
     * Let's say that we add some accessories packages Basic and Sport
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ICar objCar = new LuxuryCar();
            CarAccesoriesDecorator cad = new SportAccesories(objCar);

            Console.WriteLine(cad.GetCost());
            Console.WriteLine(cad.GetDescription());

            Console.WriteLine("Hello from decorator pattern");
            Console.ReadLine();
        }
    }
}
