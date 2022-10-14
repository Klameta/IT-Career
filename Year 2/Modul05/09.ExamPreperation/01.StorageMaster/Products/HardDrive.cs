using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Products
{
    public class HardDrive : Product
    {
        public HardDrive(double price) : base(price)
        {
            Weight = 1;
        }
    }
}
