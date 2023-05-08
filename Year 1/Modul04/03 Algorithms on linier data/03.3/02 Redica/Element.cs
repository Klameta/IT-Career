using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Redica
{
    public class Element
    {
        public int value;
        public Element previous;

        public int Value { get => value; set => this.value = value; }
        public  Element Previous { get => previous; set => previous = value; }
        public Element(int value, Element previous)
        {
            this.value = value;
            this.previous = previous;
        }
    }
}
