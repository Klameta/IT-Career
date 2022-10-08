using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephone
{
    interface ICalling
    {
        List<string> Numbers { get; set; }

        void Call();
    }
}
