using System;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int startingPoint = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            int movement = 0;
            int attack = 1;

            while (command != "Supernova")
            {
                string[] commands = Console.ReadLine()
                      .Split(' ')
                      .ToArray();
                if (commands[0] == "left")
                {
                    movement = int.Parse(commands[1]);
                    if (startingPoint - movement <= -1)
                    {
                        attack++;
                        startingPoint = arr.Length - 1;
                        arr[startingPoint - movement] -= attack;
                    }
                    else
                    {
                        arr[startingPoint - movement] -= attack;
                    }


                }
                else if (commands[1] == "right")
                {

                    if (startingPoint + movement >= arr.Length - 1)
                    {
                        attack++;
                        startingPoint = 0;
                        arr[startingPoint + movement] -= attack;
                    }
                    else
                    {
                        arr[startingPoint + movement] -= attack;
                    }


                }
                Console.WriteLine(string.Join(' ', arr));

            }




        }
    }
}
