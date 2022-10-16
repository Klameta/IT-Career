using _01.StorageMaster.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StorageMaster.Vechicles
{
    public abstract class Vehicle
    {
        private int capacity;
        private List<Product> trunk;
        private bool isFull;
        private bool isEmpty;
        protected Vehicle(int capacity)
        {
            Capacity = capacity;
            trunk = new List<Product>();
        }

        public void LoadProduct(Product product) //done
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            trunk.Add(product);

            //add to trunk, done
        }
        public Product Unload() //done
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var result = trunk.Last();
            trunk.Remove(result);

            return result;

        }

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        public bool IsEmpty => trunk.Count == 0;
        public IReadOnlyCollection<Product> Trunk => trunk;
        public bool IsFull => trunk.Sum(x => x.Weight) >= Capacity;

    }
}
