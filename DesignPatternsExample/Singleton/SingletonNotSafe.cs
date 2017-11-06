using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonNotSafe
    {
        private static SingletonNotSafe _instance = null;

        private SingletonNotSafe() { }

        public void SayHelloToSingleton()
        {
            Console.WriteLine("Hello Singleton not safe");
        }

        public static SingletonNotSafe Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonNotSafe();
                }
                return _instance;
            }
        }

    }
}
