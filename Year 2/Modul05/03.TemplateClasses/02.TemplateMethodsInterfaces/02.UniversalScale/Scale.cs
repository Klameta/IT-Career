using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UniversalScale
{
    public class Scale<T> where T: IComparable<T>
    {
        private T left;

        private T right;

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T Left
        {
            get { return left; }
            set { left = value; }
        }

        public T Right
        {
            get { return right; }
            set { right = value; }
        }
        public int GetHeavier()
        {
            return left.CompareTo(right);
        }


    }
}
