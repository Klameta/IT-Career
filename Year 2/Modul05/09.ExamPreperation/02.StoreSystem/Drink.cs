using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StoreSystem
{
    public class Drink : Product
    {
        //може и без override, ако сложим проверката в конструктора
        public override double PercentageMarkup
        {
            get => base.PercentageMarkup;
            set
            {
                base.PercentageMarkup = value;
                if (value > 200)
                {
                    throw new ArgumentException("Drink percentage markup cannot be above 200%!");
                }
            }
        }
        public Drink(string name, int quantity, double deliverPrice, double percentageMarkup)
            : base(name, quantity, deliverPrice, percentageMarkup)
        {
        }
    }

}
