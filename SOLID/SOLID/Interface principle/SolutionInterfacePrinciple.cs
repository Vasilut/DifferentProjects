using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_principle
{
    /*
     * The solution is to create a new interface for the clients that demand the new interface
     * so, we'll have the IOperation interface with the Add method
     * we'll create a new interfrace IOperationExtended which extend the IOperation for clients who whants Read method.
     */

    public interface IOperation
    {
        void Add();
    }

    public interface IOperationExtended : IOperation
    {
        void Read();
    }

    public class ClientWithRead : IOperationExtended
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }

    public class NormalClient : IOperation
    {
        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    public class ExecutionInterface
    {
        public void Execute()
        {
            IOperation op = new NormalClient(); //client with add operation
            IOperationExtended opExtended = new ClientWithRead();
        }
    }

}
