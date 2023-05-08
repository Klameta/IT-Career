using System.Collections.Generic;
using System;

namespace _02_Redica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Queue<Element> nums = new Queue<Element>();
            nums.Enqueue(new Element(n, null));
            while (nums.Count != 0)
            {
                Element currElement = nums.Dequeue();
                if (currElement.value < m)
                {
                    nums.Enqueue(new Element(currElement.value + 1,currElement));
                    nums.Enqueue(new Element(currElement.value + 2, currElement));
                    nums.Enqueue(new Element(currElement.value * 2, currElement));
                }

                if (currElement.value == m)
                {
                    PrintSequence(currElement.previous);
                    Console.WriteLine(currElement.value);
                    return;
                }
            }
        }

        static void PrintSequence(Element t)
        {
            if (t != null)
            {
                PrintSequence(t.Previous);
                Console.Write(t.Value + " -> ");
            }
        }
    }
}
