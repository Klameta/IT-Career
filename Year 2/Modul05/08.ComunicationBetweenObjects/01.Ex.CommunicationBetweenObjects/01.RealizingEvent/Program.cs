using System;

namespace _01.RealizingEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string line = Console.ReadLine();
            while (line!= "End")
            {
                dispatcher.Name = line;
                line = Console.ReadLine();
            }
        }
    }
}
