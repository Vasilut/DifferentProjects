namespace Decorator
{
    public class BasicAccesories : CarAccesoriesDecorator
    {
        public BasicAccesories(ICar car) : base(car)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Basic Accessories Package";
        }
    }
}
