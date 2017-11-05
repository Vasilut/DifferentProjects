using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_principle
{
    /*
     * Problem: we need to add a new operation (Read operation).
    Looking to the Liskov solution, we have the IOperation interface. If we'll add the Read operation a lot of customers will be impacted.
    */
    public interface IOperationBad
    {
        void Add();
        void Read(); //operation for the new client
    }
}
