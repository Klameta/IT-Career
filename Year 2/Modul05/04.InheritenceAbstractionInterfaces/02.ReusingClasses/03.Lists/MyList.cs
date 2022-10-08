using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lists
{
    class MyList:List<int>
    {
        public void PrintBackwards()
        {
            for (int i = 0; i < base.Count-1; i++)
            {
                Console.WriteLine(base[i]);
            }
        }
    }
}
