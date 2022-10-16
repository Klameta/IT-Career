using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster
{
    public class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string name, IEnumerable<Vehicle> vehicles) : base(name, 1, 2, vehicles)
        {
        }
    }
}
