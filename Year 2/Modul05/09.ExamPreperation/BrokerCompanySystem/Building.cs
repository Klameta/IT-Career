using System;
using System.Collections.Generic;
using System.Text;

namespace BrokerCompanySystem
{
    public abstract class Building
    {
        private string name;
        private string city;
        private int stars;
        private double rentAmount;

        protected Building(string name, string city, int stars, double rentAmount)
        {
            Name = name;
            City = city;
            Stars = stars;
            RentAmount = rentAmount;
            IsAvailable = true; //THIS MIGHT BE A PROBLEM
        }

        public override string ToString()
        {
            return $"****Building: {Name} <{Stars}>" +
                $"\n****Location: {City}" +
                $"\n****RentAmount: {RentAmount}" +
                $"\n****Is Available: {IsAvailable}".TrimEnd();
        }

        virtual public string Name
        {
            get { return name; }
            protected set
            {
                if (value == null || value==string.Empty) throw new ArgumentException("Building name must not be null or empty!");

                name = value;

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
        public int Stars
        {
            get { return stars; }
            private set
            {
                if (value < 0 || value > 5) throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                stars = value;
            }
        }
        public double RentAmount
        {
            get { return rentAmount; }
            private set
            {
                if (value <= 0) throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                rentAmount = value;
            }
        }
        public bool IsAvailable { get; set; }

    }
}
