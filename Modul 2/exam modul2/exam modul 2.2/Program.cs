using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exam_modul_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> patients = Console.ReadLine()
                .Split(' ', ',')
                .Where(x => x!= "")
                .ToList();

            string commmand = Console.ReadLine();
            string name = "";
            var position = 0;
            while (commmand != "END OF PATIENTS")
            {

                switch (commmand)
                {
                    case "Add patient":
                        name = Console.ReadLine();
                        patients.Add(name);
                        break;
                    case "Add patient on position":
                        name = Console.ReadLine();
                        position = int.Parse(Console.ReadLine());
                        patients.Insert(position, name);
                        break;
                    case "Remove patient on position":
                        position = int.Parse(Console.ReadLine());
                        patients.RemoveAt(position);
                        break;
                    case "Remove last patient":
                        patients.RemoveAt(patients.Count-1);
                        break;
                    case "Remove first patient":
                        patients.RemoveAt(0);
                        break;
                }
                commmand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', patients));
        }
    }
}
