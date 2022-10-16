using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StorageMaster.Products
{
    public abstract class Product
    {
        private double price;
        private double weight;

        protected Product(double weight, double price)
        {
            Weight = weight;
            Price = price;
        }
                
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                else
                {
                    price = value;
                }

            }
        }

    }
}
