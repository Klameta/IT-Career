using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Products
{
    public class Gpu : Product
    {
        public Gpu( double price) : base( price)
        {
            Weight = 0.7;
        }
    }
}
