using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public class Cat : Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + $"\nMEEOW";
        }
    }
}
