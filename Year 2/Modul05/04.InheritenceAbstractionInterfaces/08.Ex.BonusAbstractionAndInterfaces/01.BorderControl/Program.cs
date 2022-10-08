using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInhabitant> inhabitants = new List<IInhabitant>();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0]!="End")
            {
                if (cmdArgs.Length==2)
                {
                    Robot robot = new Robot(cmdArgs[1], cmdArgs[0]);
                    inhabitants.Add(robot);
                }
                else
                {
                    Human human = new Human(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                    inhabitants.Add(human);
                }
                cmdArgs = Console.ReadLine().Split();
            }

            string emigrants = new string (Console.ReadLine().Reverse().ToArray());
            List<IInhabitant> illegal = new List<IInhabitant>();
            foreach (var inhabitant in inhabitants)
            {
                string lastThree = new string(inhabitant.Id.Reverse().Take(emigrants.Length).ToArray());
                if (lastThree==emigrants)
                {
                    illegal.Add(inhabitant);
                }
            }

            Console.WriteLine(string.Join("\n", illegal));
        }

    }
}
