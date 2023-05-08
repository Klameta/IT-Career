using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DivingPart2
{
    class RationalNumber
    {
        private int numerator;
        private int denumerator;

        public RationalNumber(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }
    }
}
