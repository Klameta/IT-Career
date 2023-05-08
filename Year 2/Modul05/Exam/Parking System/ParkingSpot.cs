using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ParkingSpot
{
    private int id;
    private string type;
    private double price;
    private bool occupied;
    private List<ParkingInterval> parkingIntervals;

    protected ParkingSpot(int id, bool occupied, string type, double price)
    {
        Id = id;
        Occupied = occupied;
        Type = type;
        Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public override string ToString()
    {
        return $"> Parking Spot #{Id}" +
            $"\n> Occupied: {!Occupied}" +
            $"\n> Type: {Type}" +
            $"\n> Price per hour: {Price:F2} BGN";
    }


    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (!occupied && this.type == type)
        {
            parkingIntervals.Add(new ParkingInterval(this, registrationPlate, hoursParked));
            return true;
        }
        return false;
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return parkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }

    public virtual double CalculateTotal()
    {
        return parkingIntervals.Sum(x => x.Revenue);
    }


    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public bool Occupied //might not work
    {
        get { return occupied; }
        set { occupied = value; }
    }

    public string Type
    {
        get { return type; }
        private set { type = value; }
    }

    public double Price
    {
        get { return price; }
        private set
        {
            if (value <= 0) throw new ArgumentException("Parking price cannot be less or equal to 0!");
            price = value;
        }
    }


}
