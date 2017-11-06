using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarAccesoriesDecorator : ICar
    {
        private ICar _car;
        public CarAccesoriesDecorator(ICar car)
        {
            _car = car;
        }
        public virtual double GetCost()
        {
            return _car.GetCost();
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }
    }
}
