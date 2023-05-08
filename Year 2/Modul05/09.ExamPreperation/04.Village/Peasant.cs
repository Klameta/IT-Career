using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Village
{
    public class Peasant : Person
    {
        private int productivity;
        public Peasant(string name, int age, int productivity) : base(name, age)
        {
            this.Productivity = productivity;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nProductivity: {Productivity}";
        }

        public override int Age
        {
            get => this.Age;
            protected set
            {
                base.Age = value;
                if (value > 110)
                {
                    throw new ArgumentException("Age cannot be greater than 110!");
                }
            }
        }



        public int Productivity
        {
            get { return productivity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Productivity cannot be less or equal to 0!");
                }
                productivity = value;
            }
        }

    }
}
