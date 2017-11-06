using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonSafe
    {
        //is safe but not eficient
        private static SingletonSafe _instance = null;
        private static readonly object lockObj = new object();

        private SingletonSafe() { }

        public void SayHelloToSingleton()
        {
            Console.WriteLine("Hello from SingletonSafe");
        }

        public static SingletonSafe Instance
        {
            get
            { 
                //each time when we need an instance we need to lock (which is very costly)
                lock(lockObj)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonSafe();
                    }

                    return _instance;
                }
            }
        }

    }
}
