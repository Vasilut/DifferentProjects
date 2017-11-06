using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        void Subscribe(Observver observer);
        void Unsubsribe(Observver observer);
        void Notify();
    }
}
