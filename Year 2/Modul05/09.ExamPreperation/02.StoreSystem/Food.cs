using System;
using System.Collections.Generic;
using System.Text;

namespace _02.StoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Food : Product
    {
        //може и без override, ако сложим проверката в конструктора
        public override double PercentageMarkup
        {
            get => base.PercentageMarkup;
            set
            {
                base.PercentageMarkup = value;
                if (value > 100)
                {
                    throw new ArgumentException("Foob percentage markup cannot be above 100%!");
                }
            }
        }
        public Food(string name, int quantity, double deliverPrice, double percentageMarkup)
            : base(name, quantity, deliverPrice, percentageMarkup)
        {
        }
    }


}
