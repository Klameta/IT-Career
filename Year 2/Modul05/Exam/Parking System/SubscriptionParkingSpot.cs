using System;
using System.Collections.Generic;
using System.Text;

    public class SubscriptionParkingSpot : ParkingSpot
    {
        public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
        {
            RegistrationPlate = registrationPlate;
        }

        private string registrationPlate;

        public string RegistrationPlate
        {
            get { return registrationPlate; }
            private set
            {
                if (value == null || value == string.Empty) throw new ArgumentException("Registration plate can’t be null or empty!");
                registrationPlate = value;
            }
        }

    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        return base.ParkVehicle(registrationPlate,hoursParked, type);
    }

    public override double CalculateTotal()
    {
        return 0;
    }
}
