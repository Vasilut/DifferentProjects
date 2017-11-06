using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject : ISubject
    {
        private List<Observver> _observers = new List<Observver>();

        private int _int;
        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
          if (value > _int)
                    Notify();
                _int = value;
            }
        }

        public void Notify()
        {
            _observers.ForEach(x => x.Update());
        }

        public void Subscribe(Observver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubsribe(Observver observer)
        {
            _observers.Remove(observer);
        }
    }
}
