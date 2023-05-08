using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Buffer
{
    class Program
    {
        static void Main(string[] args)
        {
            BufferdConsole bufferdConsole = new BufferdConsole();

            bufferdConsole.Write(new string('W', 49));
            bufferdConsole.Write(new string('O', 2));
            bufferdConsole.Write(new string('b', 20));
            bufferdConsole.Write(new string('r', 20));
            bufferdConsole.Write(new string('*', 20));
            bufferdConsole.Dispose();
        }
    }
}
