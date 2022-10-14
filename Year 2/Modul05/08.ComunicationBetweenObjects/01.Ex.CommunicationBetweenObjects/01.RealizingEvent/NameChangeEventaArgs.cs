using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RealizingEvent
{
    public class NameChangeEventsArgs : EventArgs
    {
        public NameChangeEventsArgs(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
