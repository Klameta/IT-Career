using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables= new List<IBirthable>();
            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "End")
            {
                switch (cmdArgs[0])
                {
                    case "Pet":
                        Pet pet = new Pet(cmdArgs[2], cmdArgs[1]);
                        birthables.Add(pet);
                        break;
                    case "Citizen":
                        Human human = new Human(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3], cmdArgs[4]);
                        birthables.Add(human);
                        break;
                }
                cmdArgs = Console.ReadLine().Split();
            }
            string year = Console.ReadLine();
            List<IBirthable> birthdays = new List<IBirthable>();

            foreach (var birthable in birthables)
            {
                if (birthable.Birthday.EndsWith(year))
                {
                    birthdays.Add(birthable);
                }
            }
            Console.WriteLine(string.Join("\n", birthdays));
        }
    }
}
