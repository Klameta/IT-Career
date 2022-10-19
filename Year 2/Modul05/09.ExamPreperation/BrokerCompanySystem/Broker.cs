using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    public class Broker
    {
        private string name;
        private int age;
        private string city;
        private double bonus;
        private List<Building> buildings;

        public Broker(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
            buildings = new List<Building>();
            bonus = 0;//might not work
        }

        public double ReceiveBonus(Building building)
        {
            var bonusToAdd = building.RentAmount * 2 * building.Stars / 100;
            bonus += bonusToAdd;
            buildings.Add(building);
            return bonusToAdd;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"****Broker: {Name} <{Age}>");
            stringBuilder.AppendLine($"\n****Location: {City}");
            stringBuilder.AppendLine($"\n****Bonus: {Bonus}");

            foreach (var bui in buildings)
            {
                stringBuilder.AppendLine($"******{bui.Name}");
            }
            return stringBuilder.ToString().TrimEnd();
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value == string.Empty) throw new ArgumentException("Broker name must not be null or empty!");
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 16 || value > 70) throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                age = value;
            }
        }
        public string City
        {
            get { return city; }
            private set
            {
                if (value == null || value == string.Empty) throw new ArgumentException("City must not be null or empty!");
                city = value;
            }
        }
        public double Bonus
        {
            get { return bonus; }
            private set { bonus = value; }
        } //not defined?



    }

}
