using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StackOfStrings
{
    class StackOfStrings
    {
        private List<string> data;
        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string str)
        {
            this.data.Add(str);
        }

        public string Pop()
        {
            string result = this.data[data.Count - 1];
            this.data.Remove(this.data[this.data.Count - 1]);
            return result;
        }
        
        public string Peek()
        {
            string result = this.data[this.data.Count - 1];
            return result;
        }
        public bool IsEmpty()
        {
            if (this.data.Count==0)
            {
                return false;
            }
            return true;
        }
    }
}
