using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsabilityPrinciple
{
    //this class should not doing log activity, so its over loaded with lot of responsability
    public class Customer
    {
        public void Add()
        {
            try
            {
                //operations
            }
            catch(Exception ex)
            {
                File.WriteAllText(@"file.txt", ex.ToString()); //here is the problem
            }
        }
    }
}
