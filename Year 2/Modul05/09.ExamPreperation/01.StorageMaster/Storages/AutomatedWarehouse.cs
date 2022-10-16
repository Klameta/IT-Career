using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private static IEnumerable<Vehicle> tempVehicles = new Truck[1];
        public AutomatedWarehouse(string name) : base(name, 1, 2, tempVehicles)
        {
        }
    }
}
