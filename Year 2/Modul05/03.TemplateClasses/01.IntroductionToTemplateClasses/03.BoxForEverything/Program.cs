using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BoxForEverything
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>();
            box1.Add(1234);
            box1.Add(1564);
            Console.WriteLine(box1);

            Box<string> stringBox = new Box<string>();
            stringBox.Add("dfssgd");
            stringBox.Add("dfsdfgdfd");
            Console.WriteLine(stringBox);
        }
    }
}
