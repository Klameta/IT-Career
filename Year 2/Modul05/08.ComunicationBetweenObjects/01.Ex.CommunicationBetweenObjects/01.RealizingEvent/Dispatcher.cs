using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RealizingEvent
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventsArgs args);
    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChange(new NameChangeEventsArgs(value));
            }
        }

        public event NameChangeEventHandler NameChange;
        private void OnNameChange(NameChangeEventsArgs args)
        {
            NameChange(this, args);
        }

       
    }
}
