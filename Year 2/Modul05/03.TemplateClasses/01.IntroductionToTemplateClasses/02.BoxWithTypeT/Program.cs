using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BoxWithTypeT
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(3);
            box.Add(3);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(4);
            Console.WriteLine(box.Remove());

            MyIntBox myIntBox = new MyIntBox();
            myIntBox.Add(3);
            myIntBox.Add(3);
        }
    }
}
