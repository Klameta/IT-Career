using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strings = new ArrayList();
            strings.Add("1");
            strings.Add(2);
            strings.Add(4);

            Console.WriteLine(strings[0]);
            Console.WriteLine((int)strings[1]+(int)strings[2]);
        }

    }
}
