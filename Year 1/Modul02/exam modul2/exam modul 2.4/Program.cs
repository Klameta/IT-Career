using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_modul_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> players = new SortedDictionary<string, int>();
            string current = Console.ReadLine();
            while (current != "End of match")
            {
                string[] passes = current.Split(" - ").ToArray();
                string playerName = passes[0];
                int playerPasses = int.Parse(passes[1]);

                if (!(players.ContainsKey(playerName)))
                {
                    players.Add(playerName, playerPasses);
                }
                else
                {
                    players[playerName] += playerPasses;
                }
                current = Console.ReadLine();

            }

            foreach (var pair in players)
            {
                Console.WriteLine($"{pair.Key} has passed {pair.Value} passes.");
            }



        }
    }
}
