using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    /*
     * There are n numbers of observers (objects) which are interested in a special object (called the subject)
     * we're registry (subscribe) to subject (publisher)
     * the subject notify with some news
     * clienti abonati la oferte din magazin
    */
    class Program
    {

        static void Main(string[] args)
        {
            Subject store = new Subject();

            //client1 take a subscription to the store
            Observver client1 = new Observver("Lucian");
            store.Subscribe(client1);


            //client2 take a subscription to the store
            Observver client2 = new Observver("Alina");
            store.Subscribe(client2);
            store.Inventory++;


            Console.WriteLine("------------------------");

            //alina left the subscription but a new user subcripted to the store
            store.Unsubsribe(client2);
            store.Subscribe(new Observver("Feli"));
            store.Inventory++;

            Console.WriteLine("------------------------");

            Console.WriteLine("Hello from observer pattern");
            Console.ReadLine();
        }
    }
}
