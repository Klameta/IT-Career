using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EvenNumber
{
    class EvenNums
    {
        private int num;

        public int Num
        {
            get { return num; }
            set
            {
                if (value % 2 == 0)
                {
                    num = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{Num}";
        }
        public EvenNums(int num)
        {
            Num = num;
        }


    }
}
