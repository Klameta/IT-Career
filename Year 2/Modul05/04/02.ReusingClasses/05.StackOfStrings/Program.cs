using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            stackOfStrings.Push("asd");
            stackOfStrings.Push("gf");
            stackOfStrings.Push("kjsf");
            stackOfStrings.Push("sdgkj");

            Console.WriteLine(stackOfStrings.Pop());
            Console.WriteLine(stackOfStrings.Peek());
            Console.WriteLine(stackOfStrings.IsEmpty());
        }
    }
}
