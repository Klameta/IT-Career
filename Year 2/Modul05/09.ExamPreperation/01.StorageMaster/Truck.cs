using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster
{
    public class Truck : Vehicle
    {
        public Truck(int capacity) : base(capacity)
        {
            Capacity = 5;
        }
    }
}
