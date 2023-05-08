using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bon_apetit
{
    class Product
    {
        private string name;
        private double price;
        private int weight;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }

        public Product(string name, double price, int weight)
        {

        }
        public void AddProduct(string name, double price, double weight)
        {

        }


    }
}
