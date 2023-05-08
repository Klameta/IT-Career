using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Observer
{
    internal interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void NotifyObsers();

    }
}
