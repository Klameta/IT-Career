using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trees
{
    class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.children = children;
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(value);

            foreach (var child in children)
            {
                child.Print(indent + 1);
            }
        }

        public IEnumerable<T> OrderDFS()
        {
            IList<T> order = new List<T>();
            DFS(order);
            return order;
        }

        private void DFS(IList<T> order)
        {
            foreach (var child in children)
            {
                child.DFS(order);
            }

            order.Add(value);
        }

        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> queue = new Queue<Tree<T>>();

            queue.Enqueue(this);

            while(queue.Count > 0)
            {
                Tree<T> element = queue.Dequeue();
                order.Add(element.value);
                foreach (var child in element.children)
                {
                    queue.Enqueue(child);
                }
            }
            return order;
        }
    }
}