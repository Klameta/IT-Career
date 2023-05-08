using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Village
{
    public class Rebel : Person
    {
        private int harm;
        public Rebel(string name, int age, int harm) : base(name, age)
        {
            Harm = harm;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n Harm: {Harm}";
        }

        public override int Age
        {
            get => this.Age;
            protected set
            {
                base.Age = value;
                if (this.Age > 50) throw new ArgumentException("Age should be less or equal to 50!");
            }
        }
        public int Harm
        {
            get { return harm; }
            private set
            {
                if (value <= 0) throw new ArgumentException("Harm should be greater than 0!");
                harm = value;
            }
        }

    }
}
