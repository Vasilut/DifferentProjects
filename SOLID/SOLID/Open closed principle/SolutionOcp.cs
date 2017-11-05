using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_closed_principle
{
    /*
     *  In other words every time a new client type needs to be added
     *   we create a new class as shown in the below. So whatever is the current code they are untouched and we just need to test and check the new classes.
     *   
     *   The ClientGood class is now closed for any new modification but it's open for extension
    */
    public class ClientGood
    {
        public virtual int GetMoney(int totalAmount)
        {
            return totalAmount;
        }
    }

    public class GoldClient:ClientGood
    {
        public override int GetMoney(int totalAmount)
        {
            return base.GetMoney(totalAmount) - 100;
        }
    }

    public class SilverClient:ClientGood
    {
        public override int GetMoney(int totalAmount)
        {
            return base.GetMoney(totalAmount) - 50;
        }
    }
}
