using _01.StorageMaster.Products;
using _01.StorageMaster.Storages;
using _01.StorageMaster.Vechicles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _01.StorageMaster
{
    public class StorageMaster
    {
        List<Product> products = new List<Product>();
        List<Storage> storages = new List<Storage>();
        Vehicle vehicle;
        public string AddProduct(string type, double price)
        {
            Product product;

            switch (type)
            {
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;
                case "Ram":
                    product = new Ram(price);
                    break;
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid product type!");
                    break;
            }

            products.Add(product);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage;

            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException($"Invalid storage type!");
                    break;
            }

            storages.Add(storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            vehicle = storages.FirstOrDefault(x => x.Name == storageName).Garage.ToArray()[garageSlot];

            return $"Selected {vehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            int productCount = productNames.Count();

            foreach (var product in productNames)
            {
                if (!vehicle.IsFull)
                {
                    var currProduct = products.FirstOrDefault(x => x.GetType().Name == product);

                    if (currProduct == null) throw new InvalidOperationException($"{product} is out of stock!");

                    products.Remove(currProduct);
                    vehicle.LoadProduct(currProduct);
                    loadedProductsCount++;
                }
            }

            return $"Loaded {loadedProductsCount}/{productCount} products into {vehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            var sourceStorage = storages.FirstOrDefault(x => x.Name == sourceName);
            var destinationStorage = storages.FirstOrDefault(x => x.Name == destinationName);

            if (sourceStorage == null) throw new InvalidOperationException("Invalid source storage!");
            if (destinationStorage == null) throw new InvalidOperationException("Invalid destination storage!");

            var vehicle = sourceStorage.GetVehicle(sourceGarageSlot);
            int slot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {slot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = storages.FirstOrDefault(x => x.Name == storageName);
            var currVehicle = storage.GetVehicle(garageSlot);
            int productsInVehicle = currVehicle.Trunk.Count();
            int loaded = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {loaded}/{productsInVehicle} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            var storage = storages.FirstOrDefault(x => x.Name == storageName);

            var Gpus = storage.Products.GroupBy(x => x.GetType().Name == "Gpu");
            var Rams = storage.Products.GroupBy(x => x.GetType().Name == "Ram");
            var SolidStateDrives = storage.Products.GroupBy(x => x.GetType().Name == "SolidStateDrive");
            var HardDrives = storage.Products.GroupBy(x => x.GetType().Name == "HardDrive").Select(x=>x);
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }


    }
}
