using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TemplateMethodForCountingDoubles
{
    public class Comperer<T>
    {
        public static int CountGreater<T>(T compare, List<T> types) where T : IComparable<T>
        {
            int counter = 0;
            foreach (var token in types)
            {
                if (compare.CompareTo(token) < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
