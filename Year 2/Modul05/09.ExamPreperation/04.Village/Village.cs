using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Village
{
    public class Village
    {
        private string name;
        private string location;
        private int resource;
        private List<Peasant> peasants;

        public Village(string name, string location)
        {
            Name = name;
            Location = location;
            Resource = 0;
            peasants = new List<Peasant>();
        }

        public void AddPeasant(Peasant peasant)
        {
            peasants.Add(peasant);
        }
        public int PassDay()
        {
            int toAdd = peasants.Sum(x => x.Productivity);
            resource += toAdd;
            return toAdd;
        }
        public List<Peasant> KillPeasants(int count)
        {
            List<Peasant> peasantsone = peasants.Take(count).ToList();
            peasants.RemoveRange(0, count);
            return peasantsone;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Village - {Name} ({Location})");
            stringBuilder.AppendLine($"Resources - {Resource}");
            stringBuilder.AppendLine($"Peasants – ({peasants.Count})");
            foreach (var pes in peasants)
            {
                stringBuilder.AppendLine(pes.ToString());
            }
            return stringBuilder.ToString().TrimEnd();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (!(value.Length >= 2 || value.Length <= 40)) throw new ArgumentException("Name should be between 2 and 40 characters!");

                name = value;
            }
        }

        public string Location
        {
            get { return location; }
            private set
            {
                if (!(value.Length >= 2 || value.Length <= 40)) throw new ArgumentException("Location should be between 2 and 40 characters!");
                location = value;
            }
        }

        public int Resource
        {
            get { return resource; }
             set { resource = value; }
        }


    }
}
