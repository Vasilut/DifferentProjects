using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SportAccesories : CarAccesoriesDecorator
    {
        public SportAccesories(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 2000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "Sport Accesories Package";
        }
    }
}
