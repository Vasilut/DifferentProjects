using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_closed_principle
{
    /*
    The problem is if we add a new customer type we need 
    to go and add one more “IF” condition in the “GetMoney” function, in other words we need to change the client class.

    In other words we are “MODIFYING” the current client code for every change
    and every time we modify we need to ensure that all the previous functionalities and connected client are working as before.
     */
    public class Client
    {
        private int _clientType;
        public int ClientType
        {
            get
            {
                return _clientType;
            }
            set
            {
                _clientType = value;
            }
        }

        public int GetMoney(int totalAmount)
        {
            if(ClientType == 1)
            {
                return totalAmount - 100;
            }
            else
            {
                return totalAmount - 50;
            }
        }
    }
}
