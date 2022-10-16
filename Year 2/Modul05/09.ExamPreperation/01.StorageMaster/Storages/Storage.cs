using _01.StorageMaster.Products;
using _01.StorageMaster.Vechicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StorageMaster.Storages
{
    public abstract class Storage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private List<Product> products;
        private Vehicle[] garage;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            garage = vehicles.ToArray();
            products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }
        public bool IsFull
        {
            get { return isFull; }
            set { isFull = products.Count >= capacity; }
        }
        public IReadOnlyCollection<Product> Products
        {
            get { return products; }
        }
        public IReadOnlyCollection<Vehicle> Garage => garage;


        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots) throw new InvalidOperationException($"Invalid garage slot!");
            if (garage[garageSlot] == null) throw new InvalidOperationException($"No vehicle in this garage slot!");
            return garage[garageSlot];
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = GetVehicle(garageSlot);
            int index = -1;
            for (int i = 0; i < deliveryLocation.GarageSlots; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    index = i;
                    deliveryLocation.garage[i] = vehicle;
                    break;
                }
            }

            if (index == -1) throw new InvalidOperationException($"No room in garage!");

            return index;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull) throw new InvalidOperationException($"Storage is full!");
            var vehicle = GetVehicle(garageSlot);
            int count = 0;

            while (!vehicle.IsEmpty && !IsFull)
            {
                var temp = vehicle.Unload();
                products.Add(temp);

                count++;
            }

            return count;
        }
    }

}
