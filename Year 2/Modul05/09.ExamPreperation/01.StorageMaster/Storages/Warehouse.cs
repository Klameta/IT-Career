using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Storages
{
    public class Warehouse : Storage
    {
        private static IEnumerable<Semi> semis = new Semi[3];
        public Warehouse(string name) : base(name, 10, 10, semis)
        {
        }
    }
}
