using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            list.Add(9);
            list.Add(1);
            list.Add(4);
            list.Add(45);
            list.Add(6);

            list.PrintBackwards();
        }
    }
}
