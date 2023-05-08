using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _05.Collection
{
    internal class ListIterator<T> : IEnumerable<T>
    {
        private IReadOnlyList<T> list;
        private int index = 0;

        public ListIterator(params T[] list)
        {
            this.list = new List<T>(list);
        }

        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext() => index < list.Count - 1;
        public void Print()
        {
            if (index < 0|| index>=list.Count)
            {
                Console.WriteLine("Invalid Operation!");
                return;
            }
            Console.WriteLine(list[index]);
        }
        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
