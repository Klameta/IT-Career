using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BoxWithTypeT
{
    public class Box<T>
    {
        private int count;

        private List<T> list;
        public int Count => this.list.Count;
        
        public void Add(T item)
        {
            this.list.Add(item);
        }
        public T Remove()
        {
            var item = list.Last();
            list.RemoveAt(list.Count - 1);
            return item;
        }
        public Box()
        {
            List<T> list = new List<T>();
        }


    }
    class MyIntBox : Box<int>
    {

    }
}
