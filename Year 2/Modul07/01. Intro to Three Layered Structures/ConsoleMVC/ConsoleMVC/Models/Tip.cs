using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Models
{
    public class Tip
    {
        private double amount;
        private double percent;

        public Tip() : this(0, 0) { }
        public Tip(double amount, double percent)
        {
            Amount = amount;
            Percent = percent;
        }

        public double CalcuateTip()
        {
            return Amount * Percent;
        }

        public double   CalculateTotal()
        {
            return Amount + CalcuateTip();
        }

        public double Amount
        {
            get { return amount; }
            private set { amount = value; }
        }
        public double Percent
        {
            get { return percent; }
            private set
            {
                if (value > 0)
                {
                    percent = value / 100;
                }
                else
                {
                    percent = value;
                }
            }
        }


    }
}
