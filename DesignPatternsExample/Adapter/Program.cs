using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        /*
         * Allow a system to use classes of another system that is incompatible with it.
         */
        static void Main(string[] args)
        {
            ThirdPartySystem system = new ThirdPartySystem(new Adapter());
            system.ShowEmployee();

            Console.WriteLine("Hello from adapter pattern");
            Console.ReadLine();
        }
    }
}
