using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CustomList
{
    class RandomList : ArrayList
    {
        private Random rnd;
        public object RandomString()
        {
            int element = rnd.Next(0, base.Count - 1);
            string str = (string)base[element];
            base.Remove(str);
            return str;
        }
    }
}
