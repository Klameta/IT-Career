using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
  public  class Dog : Animal
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
