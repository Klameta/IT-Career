using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC.Views
{
    public class Display
    {

        public Display()
        {
            Total= 0;
            TipAmount = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter amount: ");
            Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter percent: ");
            Percent= double.Parse(Console.ReadLine());


        }

        public void ShowTipAndTotal()
        {
            Console.WriteLine($"Your tip is: {TipAmount:C}");
            Console.WriteLine($"The total will be {Total:C}");
        }

        public double Percent { get; private set; }
        public double Amount { get; private set; }
        public double Total { get; private set; }
        public double TipAmount { get; private set; }
    }
}
