using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EconomyCar : ICar
    {
        public double GetCost()
        {
            return 4500;
        }

        public string GetDescription()
        {
            return "Economy car";
        }
    }
}
