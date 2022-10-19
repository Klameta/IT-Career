using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrokerCompanySystem.Buildings
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }

        public override string Name
        {
            get => base.Name;
            protected set
            {
                base.Name = value;
                if (string.Join("", value.TakeLast(5)) != "Business") throw new ArgumentException("Name of business buildings should end on Business!");

            }

        }
    }
}
