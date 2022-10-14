using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Products
{
    public class Ram : Product
    {
        public Ram(double price) : base(price)
        {
            Weight = 0.1;
        }
    }
}
