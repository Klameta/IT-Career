using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class ParkingController
{
    private List<ParkingSpot> parkingSpots;

    public ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);
        string registrationPlate;
        ParkingSpot parking;

        if (type == "subscription")
        {
            registrationPlate = args[4];
            parking = new SubscriptionParkingSpot(id, occupied, price, registrationPlate);
        }
        else if (type == "car")
        {
            parking = new CarParkingSpot(id, occupied, price);
        }
        else if (type == "bus")
        {
            parking = new BusParkingSpot(id, occupied, price);
        }
        else
        {
            return "Unable to create parking spot!";
        }

        if (parkingSpots.Any(x => x.Id == id))
        {
            return $"Parking spot {id} is already registered!";
        }

        parkingSpots.Add(parking);
        return $"Parking spot {parking.Id} was successfully registered in the system!";

    }

    /* public string ParkVehicle(List<string> args)
     {
         int parkingSpotId = int.Parse(args[0]);
         string registrationPlate = args[1];
         int hoursParked = int.Parse(args[2]);
         string type = args[3];

         var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
         if (spot == null) return $"Parking spot {parkingSpotId} not found!";

         var parking = new ParkingInterval(spot, registrationPlate, hoursParked);


         if (!spot.ParkVehicle(registrationPlate, hoursParked, type)) return $"Vehicle {registrationPlate} can't park at {parkingSpotId}.";

         return $"Vehicle {registrationPlate} parked at {parkingSpotId} for {hoursParked} hours.";
     }*/

    public string ParkVehicle(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];

        var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (spot == null) return $"Parking spot {parkingSpotId} not found!";

        if (spot.Occupied || spot.Type != type) return $"Vehicle {registrationPlate} can't park at {parkingSpotId}.";

        var parking = new ParkingInterval(spot, registrationPlate, hoursParked);
        spot.ParkVehicle(registrationPlate, hoursParked, type);
        return $"Vehicle {registrationPlate} parked at {parkingSpotId} for {hoursParked} hours.";
    }


    /*public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);

        if (spot == null) return $"Parking spot {parkingSpotId} not found!";
        if (spot.Occupied) return $"Parking spot {parkingSpotId} is not occupied.";

        spot.Occupied = true;
        return $"Parking spot {parkingSpotId} is now free!";
    }*/
    public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);

        if (spot == null) return $"Parking spot {parkingSpotId} not found!";
        if (spot.Occupied) return $"Parking spot {parkingSpotId} is not occupied.";

        spot.Occupied = false;
        return $"Parking spot {parkingSpotId} is now free!";
    }



    public string GetParkingSpotById(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (spot == null) return $"Parking spot {parkingSpotId} not found!";

        return spot.ToString();
    }

    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];

        var spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        if (spot == null) return $"Parking spot {parkingSpotId} not found!";

        var parkings = spot.GetAllParkingIntervalsByRegistrationPlate(registrationPlate);
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Parking intervals for parking spot {spot.Id}:");
        foreach (var park in parkings)
        {
            stringBuilder.AppendLine(park.ToString());
        }

        return stringBuilder.ToString().TrimEnd();


    }

    public string CalculateTotal(List<string> args)
    {
        var temp = parkingSpots.Where(x => x.Type != "subscription");
        double total = 0;

        foreach (var t in temp)
        {
            total += t.CalculateTotal();
        }

        return $"Total revenue from the parking: {total:F2} BGN";

    }
}

