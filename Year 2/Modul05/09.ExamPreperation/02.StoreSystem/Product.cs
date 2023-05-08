using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StoreSystem
{
    public abstract class Product
    {
        private string name;
        private int quantity;
        private double deliverPrice;
        private double percentageMarkup;
        private double finalPrice;

        protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            Name = name;
            Quantity = quantity;
            DeliverPrice = deliverPrice;
            PercentageMarkup = percentageMarkup;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value)) //или value == null || value == ""
                {
                    throw new ArgumentException("Product name must not be null or empty!");
                }
                name = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity cannot be less or equal to 0!");
                }
                quantity = value;
            }
        }
        public double DeliverPrice
        {
            get { return deliverPrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Deliver price cannot be less or equal to 0!");
                }
                deliverPrice = value;
            }
        }
        public virtual double PercentageMarkup //може и да не е virtual, ако в наследника проверката е в конструктора
        {
            get { return percentageMarkup; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
                }
                percentageMarkup = value;
            }
        }
        public double FinalPrice
        {
            get
            {
                finalPrice = DeliverPrice + DeliverPrice * PercentageMarkup / 100;
                return finalPrice;
            }
        }

        public override string ToString() //може и със StringBuilder
        {
            string answer = $"****Product: {Name} <{Quantity}>\n";
            answer += $"****Deliver Price: {DeliverPrice}\n";
            answer += $"****Percentage Markup: {PercentageMarkup}\n";
            answer += $"****Final Price: {FinalPrice}";
            return answer;
        }
    }


}
