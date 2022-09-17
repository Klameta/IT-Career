using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GoingThroughUpgradedList
{
    class CustomList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> list;

        public int Count => 0;
        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }
        public CustomList()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }
        public T Remove(int index)
        {
            T removed = list[index];
            list.RemoveAt(index);
            return removed;
        }
        public bool Contains(T element)
        {
            return list.Contains(element);
        }
        public void Swap(int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;

            foreach (var token in list)
            {
                if (element.CompareTo(token) < 0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            return list.Max();
        }
        public T Min()
        {
            return list.Min();
        }
        public void Sort()
        {
            list.Sort();
        }
        public override string ToString()
        {
            return string.Join($"\n", list);
        }
    }
}
