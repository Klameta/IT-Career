using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster
{
    public class Van : Vehicle
    {

        public Van(int capacity) : base(capacity)
        {
            Capacity = 2;
        }
    }
}
