using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}
