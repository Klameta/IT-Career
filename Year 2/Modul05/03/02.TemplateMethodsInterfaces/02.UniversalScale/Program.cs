using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniversalScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> untScale = new Scale<int>(8,8);
            Console.WriteLine(untScale.GetHeavier());

        }
    }
}
