using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemplateMethodForSwitchingStrings
{
    public class Switch 
    {
        public static void Swapper<T>(List<T>types,int first, int second)
        {
            T temp = types[first];
            types[first] = types[second];
            types[second] = temp;
        }

    }
}
