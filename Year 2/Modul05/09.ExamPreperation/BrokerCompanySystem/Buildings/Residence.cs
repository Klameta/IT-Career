using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem.Buildings
{
    public class Residence : Building
    {
        public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }

        public override string Name
        {
            get => base.Name;
            protected set
            {
                base.Name = value;
                if (string.Join("", value.TakeLast(9)) != "Residence") throw new ArgumentException("Name of residence buildings should end on Residence!");

            }

        }
    }
}
