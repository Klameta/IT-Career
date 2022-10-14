using _01.StorageMaster.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.StorageMaster
{
    public abstract class Storage : IEnumerable<Vehicle>
    {
        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> garage)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = GarageSlots;
            Garage = new Vehicle[{}];
            Products = new Product[Capacity];
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int GarageSlots { get; set; }
        public bool IsFull { get; set; }
        readonly IReadOnlyCollection<Vehicle> Garage = new List<Vehicle>();
        readonly IReadOnlyCollection<Product> Products = new List<Product>();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            else if (Garage.Count==0)
            {
                throw new InvalidOperationException("No vechiles in this garage slot!");
            }
            else
            {
                return Garage.ElementAt(garageSlot);
            }
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = GetVehicle(garageSlot);

            foreach (var vehiclee in deliveryLocation)
            {

            }

            Garage.
            deliveryLocation.
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            for (int i = 0; i < GarageSlots; i++)
            {

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}
