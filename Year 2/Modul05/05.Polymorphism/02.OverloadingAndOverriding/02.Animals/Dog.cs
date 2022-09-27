using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Animals
{
    class Dog : Animal
    {
        public Dog(string name, string favFood) : base(name, favFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + $"\nDJAAF";
        }
    }
}
