using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnimalFarm
{
    abstract class Food
    {
        private int quantity;
        public int Quanity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Food(int quanity)
        {
            Quanity = quanity;
        }
    }
}
