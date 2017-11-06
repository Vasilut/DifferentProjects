using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observver : IObserver
    {
        public string ObserverName { get; private set; }
        public Observver(string name)
        {
            this.ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new product has arrived at the store", ObserverName);
        }
    }
}
