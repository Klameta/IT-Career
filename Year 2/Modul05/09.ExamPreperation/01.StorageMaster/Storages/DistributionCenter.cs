using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Storages
{
    public class DistributionCenter : Storage
    {
        private static IEnumerable<Van> vans = new Van[3];
        public DistributionCenter(string name) : base(name, 2, 5, vans)
        {
        }
    }
}
