using System;
using System.Collections.Generic;
using System.Text;

namespace _01.RealizingEvent
{
    public class Handler
    {
        public virtual void OnDispatcherNameChange(object sender, NameChangeEventsArgs args)
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}");
        }
    }
}
