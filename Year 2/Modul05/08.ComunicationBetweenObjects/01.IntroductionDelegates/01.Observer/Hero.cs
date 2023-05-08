using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Observer
{
    internal class Hero : ISubject, IObserver
    {
        private string name;
        private string reward;
        private List<IObserver> observers;

        public Hero(string name, string reward)
        {
            this.name = name;
            this.reward = reward;
            this.observers = new List<IObserver>();
        }

        public void NotifyObsers()
        {
            foreach (IObserver observer in observers)
            {
                this.observers = new List<IObserver>();
                
            }
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Update(int val)
        {
            this.reward = val;
        }
    }
}
