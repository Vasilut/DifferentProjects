using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov
{
    //we're separating the objects, in two categories: subclass of ListkovGood base class and the other.
    public interface IMoney
    {
        int GetMoney(int totalAmount);
    }

    public interface IOperation
    {
        void Add();
    }

    public class LiskovGood : IMoney, IOperation
    {
        public virtual void Add()
        {
            
        }

        public virtual int GetMoney(int totalAmount)
        {
            return totalAmount;
        }
    }

    public class GoldCustomerGood : LiskovGood
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

    public class SilverCustomerGood : LiskovGood
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

    public class PowerCustomerGood : IMoney
    {
        
        public  int GetMoney(int totalAmount)
        {
            return totalAmount - 80;
        }
    }

    public class ExecutionGood
    {
        public void Execute()
        {
            List<LiskovGood> lst = new List<LiskovGood>();
            lst.Add(new GoldCustomerGood());
            lst.Add(new SilverCustomerGood());
            //lst.Add(new PowerCustomerGood());

            foreach (var item in lst)
            {
                item.Add();
            }
        }
    }
}
