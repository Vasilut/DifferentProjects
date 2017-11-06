using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryBuilder
    {
        public static ICar GetCar(string name)
        {
            ICar car = null;
            switch (name)
            {
                case "bmw":
                    {
                        car = new Bmw();
                        break;
                    }
                case "audi":
                    {
                        car = new Audi();
                        break;
                    }
                default:
                    {
                        car = new Ferrari();
                        break;
                    }
            }
            return car;
        }
    }
}
