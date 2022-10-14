using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Products
{
    public class SolidStateDrive : Product
    {
        public SolidStateDrive(double price) : base(price)
        {
            Weight = 0.2;
        }
    }
}
