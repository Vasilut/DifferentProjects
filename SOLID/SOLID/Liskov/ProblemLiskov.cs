using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov
{
    /*
     * LISKOV principle says the parent should easily replace the child object
     * For PowerUser this is not hapenning!!!!
     */
    public class LiskovBad
    {
        public virtual void Add()
        {
            Console.WriteLine("Base add");
        }

        public virtual int GetMoney(int totalAmount)
        {
            return totalAmount;
        }
    }

    public class GoldCustomer : LiskovBad
    {
        public override void Add()
        {
            Console.WriteLine("Gold add");
        }

        public override int GetMoney(int totalAmount)
        {
            return base.GetMoney(totalAmount) - 100;
        }
    }

    public class SilverCustomer : LiskovBad
    {
        public override void Add()
        {
            Console.WriteLine("Silver add");
        }

        public override int GetMoney(int totalAmount)
        {
            return base.GetMoney(totalAmount) - 50;
        }
    }

    public class PowerCustomer : LiskovBad
    {
        public override void Add()
        {
            throw new Exception("Not alowed");
        }

        public override int GetMoney(int totalAmount)
        {
            return base.GetMoney(totalAmount) - 80;
        }
    }

    public class Execution
    {
        public void Execute()
        {
            List<LiskovBad> lst = new List<LiskovBad>();
            lst.Add(new GoldCustomer());
            lst.Add(new SilverCustomer());
            lst.Add(new PowerCustomer());

            foreach (var item in lst)
            {
                item.Add(); //problem for the power user object
            }
        }
    }
}
