using _01.StorageMaster.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster
{
   public abstract class Vehicle
    {
        protected Vehicle(int capacity)
        {
            Capacity = capacity;
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            //add to trunk
        }
        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            //remove from trunk

        }


        public int Capacity { get; set; }
        public IReadOnlyCollection<Product> Trunk { get; set; }
        public bool IsFull { get; set; }
        public bool IsEmpty { get; set; }


    }
}
