using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephone
{
    interface IEthernet
    {
       List<string> Sites { get; set; }

        void Browsing();
    }
}
