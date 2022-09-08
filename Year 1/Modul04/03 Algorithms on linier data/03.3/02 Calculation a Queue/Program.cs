using System;
using System.Collections.Generic;
using System.Linq;
namespace _02_Calculation_a_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int num = int.Parse(Console.ReadLine());
            Queue<int> nums = new Queue<int>();
            int operation = 0;
            Console.Write(num + ", ");
            for (int i = 0; i < 50; i++)
            {
                switch (counter)
                {
                    case 1:
                        operation = num + 1;
                        nums.Enqueue(operation);
                        Console.Write(operation + ", ");
                        break;
                    case 2:
                        operation = 2 * num + 1;
                        nums.Enqueue(operation);
                        Console.Write(operation + ", ");
                        break;
                    case 3:
                        operation = num + 2;
                        nums.Enqueue(operation);
                        Console.Write(operation + ", ");
                        break;
                }

                if (counter == 3)
                {
                    counter = 1;
                    num = nums.Dequeue();
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}
