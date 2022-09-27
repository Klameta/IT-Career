using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Animals
{
    class Cat : Animal
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
