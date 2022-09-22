using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> hungries = new Dictionary<string, IBuyer>();
            int people = int.Parse(Console.ReadLine());

            string[] cmdArgs = Console.ReadLine().Split();
            while(cmdArgs[0]!="End")
            {
                if (cmdArgs.Length == 4)
                {
                    if (!hungries.ContainsKey(cmdArgs[0]))
                    {
                        Human human = new Human(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3]);
                        hungries.Add(cmdArgs[0], human);
                    }
                    else
                    {
                        hungries[cmdArgs[0]].BuyFood();
                    }
                }
                else
                {
                    if (!hungries.ContainsKey(cmdArgs[0]))
                    {
                        Rebel rebel = new Rebel(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                        hungries.Add(cmdArgs[0], rebel);
                    }
                    else
                    {
                        hungries[cmdArgs[0]].BuyFood();
                    }
                }
                cmdArgs = Console.ReadLine().Split();
            }

            int foodSum = 0;
            foreach (var hungry in hungries.Keys)
            {
                foodSum += hungries[hungry].Food;
            }

            Console.WriteLine(foodSum);
        }

    }
}
