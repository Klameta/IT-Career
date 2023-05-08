using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem.Buildings
{
    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {

        }

        public override string Name
        {
            get => base.Name;
            protected set
            {
                base.Name = value;
                if (string.Join("", value.TakeLast(5)) != "Hotel") throw new ArgumentException("Name of hotel buildings should end on Hotel!");

            }

        }
    }
}
