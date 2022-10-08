using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tuple
{
    class Tuple1<T, U>
    {
        private T item1;

        private U itme2;

        public Tuple1(T item1, U item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        public U Item2
        {
            get { return itme2; }
            set { itme2 = value; }
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
