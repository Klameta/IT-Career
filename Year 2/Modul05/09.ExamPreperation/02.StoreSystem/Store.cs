using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Store
    {
        private List<Product> availableProducts;
        private string name;
        private string type;
        private double revenue;

        public Store(string name, string type)
        {
            Name = name;
            Type = type;
            availableProducts = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) //може и value == null || value == ""
                {
                    throw new ArgumentException("Store name must not be null or empty!");
                }
                name = value;
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Store type must not be null or empty!");
                }
                type = value;
            }
        }
        public double Revenue
        {
            get { return revenue; }
            set { revenue = value; }
        }

        public bool ReceiveProduct(Product product)
        {
            if (availableProducts.Any(p => p.Name == product.Name)) return false;
            //Contains не работи, защото product е нов продукт с различни бройки и др.
            //Може и с FirstOrDefault(p => p.Name == product.Name) и да проверим дали е null

            availableProducts.Add(product);
            return true;
        }

        public bool SellProduct(string name, int quantity)
        {
            Product product = availableProducts.FirstOrDefault(p => p.Name == name);
            if (product == null) return false;

            if (product.Quantity < quantity) return false;

            //Ако при продажба количеството стане 0, ще хвърли Exception
            //Затова проверяваме дали ще стане 0 и веднага трием продукта

            if (product.Quantity == quantity)
            {
                availableProducts.Remove(product);
            }
            else
            {
                product.Quantity -= quantity;
            }

            Revenue += quantity * product.FinalPrice;
            return true;
        }
        public Product GetProduct(string name)
        {
            return availableProducts.FirstOrDefault(p => p.Name == name);
        }

        public override string ToString() //може и както в Product
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Store: {Name} <{Type}>");
            sb.AppendLine($"****Available products: <{availableProducts.Count}>");
            foreach (var item in availableProducts)
            {
                sb.AppendLine($"****** {item.Name} ({item.Quantity})");
            }
            sb.Append($"****Revenue: <{Revenue:f2}BGN>");
            return sb.ToString(); //Ако на горния ред е AppendLine, тук добавяме .TrimEnd()
        }
    }


}
