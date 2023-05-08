using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Village
{
    public class Controller
    {
        Dictionary<string, Village> villiges = new Dictionary<string, Village>();
        List<Rebel> rebels = new List<Rebel>();
        int attacks = 0;
        public string ProcessVillageCommand(List<string> args)
        {
            string name = args[0];
            string location = args[1];


            Village village = new Village(name, location);
            villiges.Add(name, village);
            return $"Created Village {name}!";
            //TODO: Add some logic here …
        }

        public string ProcessSettleCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int productivity = int.Parse(args[2]);
            string villageName = args[3];


            Peasant peasant = new Peasant(name, age, productivity);
            villiges[villageName].AddPeasant(peasant);
            return $"Settled Peasant {name} in Village {villageName}!";
            //TODO: Add some logic here …
        }

        public string ProcessRebelCommand(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            int harm = int.Parse(args[2]); ;


            var rebel = new Rebel(name, age, harm);
            rebels.Add(rebel);
            return $"Rebel {name} joined the gang!";
            /* hi ivana kak si dnes slay;
             obi4am da akam we;
             we are family;
             gei;*/
            //TODO: Add some logic here …
        }

        public string ProcessDayCommand(List<string> args)
        {
            var villageName = args[0];


            int dailyResource = villiges[villageName].PassDay();
            return $"Village {villageName} resource increased with {dailyResource}!";
            //TODO: Add some logic here …
        }

        public string ProcessAttackCommand(List<string> args)
        {
            int rebelCount = int.Parse(args[0]);
            string villageName = args[1];
            if (rebels.Count == 0)
            {
                return "No rebels to perform raid...";
            }

            int harmSum = rebels.Sum(x => x.Harm);
            var village = villiges[villageName];
            village.Resource -= harmSum;
            var peasents = village.KillPeasants(rebelCount / 2);
            attacks++;

            return $"Village {villageName} lost {harmSum} resources and {peasents.Count} peasants!";
            //TODO: Add some logic here …
        }
        public string ProcessInfoCommand(List<string> args)
        {
            string side = args[0];
            StringBuilder sb = new StringBuilder();

            if (side == "Rebel")
            {
                if (rebels.Count == 0) return "No Rebels";

                sb. AppendLine("Rebels:");
                string.Join(Environment.NewLine, rebels);
            }
            else
            {
                if (villiges.Count == 0) return "No Villages";
                sb.AppendLine("Villages:");
                foreach (var vil in villiges.Values)
                {
                    sb.AppendLine(vil.ToString());
                }
                return sb.ToString().TrimEnd();
            }
            //TODO: Add some logic here …
        }

        public string ProcessEndCommand()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Villages: {villiges.Count}");
            stringBuilder.AppendLine($"Rebels: {rebels.Count}");
            stringBuilder.AppendLine($"Attacks on Villages: {attacks}");
            return stringBuilder.ToString().TrimEnd();
            //TODO: Add some logic here …
        }

    }

}
