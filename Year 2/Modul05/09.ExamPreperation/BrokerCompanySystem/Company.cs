using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem
{
    public class Company
    {
        private List<Building> buildings;
        private List<Broker> brokers;
        private string name;

        public Company(string name)
        {
            Name = name;
            brokers = new List<Broker>();
            buildings = new List<Building>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value == string.Empty) throw new ArgumentException("Company name must not be null or empty!");
                name = value;
            }
        }

        public void AddBroker(Broker broker)
        {
            if (!brokers.Any(x => x.Name == broker.Name))
            {
                brokers.Add(broker);
            }
        }
        public void AddBuilding(Building building)
        {
            if (!buildings.Any(x => x.Name == building.Name))
            {
                buildings.Add(building);
            }
        }
        public Broker GetBrokerByName(string name) => brokers.FirstOrDefault(x => x.Name == name);

        public Building GetBuildingByName(string name) => buildings.FirstOrDefault(x => x.Name == name);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Company: {Name}");
            stringBuilder.AppendLine($"**Brokers: {brokers.Count}");

            foreach (var broker in brokers)
            {
                stringBuilder.AppendLine(broker.ToString());
            }

            stringBuilder.AppendLine($"**Buildings – {buildings.Count}");

            foreach (var building in buildings)
            {
                stringBuilder.AppendLine(building.ToString());
            }
        }
    }
}
