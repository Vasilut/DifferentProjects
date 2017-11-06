using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonSafeAndPerformant
    {

        private static SingletonSafeAndPerformant _instance = null;
        private static readonly object lockObj = new object();

        private SingletonSafeAndPerformant()
        {

        }

        public void SayHelloToSingleton()
        {
            Console.WriteLine("Hello from SingletonSafeAndEficient");
        }

        public static SingletonSafeAndPerformant Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonSafeAndPerformant();
                        }

                    }
                }

                return _instance;
            }
        }

    }
}
