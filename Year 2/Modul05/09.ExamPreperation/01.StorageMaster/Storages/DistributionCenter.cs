using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StorageMaster.Storages
{
    public class DistributionCenter : Storage
    {
        private static IEnumerable<Van> vans = new Van[3];
        
        public DistributionCenter(string name) : base(name, 2, 5, vans)
        {
            Filling(vans);
        }

        public void Filling(IEnumerable<Van> vans)
        {
            var vans1 = vans.ToArray();
            for (int i = 0; i < 3; i++)
            {
                vans1[i] = new Van();
            }

            vans = vans1;
        }
    }
}
