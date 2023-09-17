using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Item { get; set; }
        }

        public Node Root { get; set; }
        public int Count { get; set; }
        public bool Contains(T item)
        {
            if (Root == null) return false;
            Node iterator = Root;
            while (true)
            {
                if (iterator == null) return false;
                if (iterator.Item.CompareTo(item) == 0) return true;
                else if (iterator.Item.CompareTo(item) < 0) iterator = iterator.Right;
                if (iterator.Item.CompareTo(item) > 0) iterator = iterator.Left;
            }
        }

        public void Add(T item)
        {
            Node node = new Node();
            node.Item = item;

            if (Root == null)
            {
                Root = node;
                return;
            }
            Node iterator = Root;
            while (true)
            {
                if (iterator.Left != null && iterator.Item.CompareTo(item) >= 0)
                {
                    iterator = iterator.Left;
                }
                else if (iterator.Right != null && iterator.Item.CompareTo(item) <= 0)
                {
                    iterator = iterator.Right;
                }
                else break;
            }
            if (iterator.Item.CompareTo(item) >= 0)
            {
                iterator.Left = node;
            }
            if (iterator.Item.CompareTo(item) <= 0)
            {
                iterator.Right = node;
            }
        }
    }
}
