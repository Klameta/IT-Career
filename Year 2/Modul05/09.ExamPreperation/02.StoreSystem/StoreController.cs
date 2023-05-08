using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.StoreSystem
{
    public class StoreController
    {
        List<Store> storeList = new List<Store>();//if ctor. remove
        public string CreateStore(List<string> args) //done?
        {
            string name = args[0];
            string type = args[1];

            if (storeList.Any(x => x.Name == name)) return $"Store {name} is already registered!";

            Store store = new Store(name, type);
            storeList.Add(store);
            return ($"Store {name} was successfully registerd in the system!");
        }

        public string ReceiveProduct(List<string> args) //done?
        {
            string type = args[0];
            string name = args[1];
            int quantity = int.Parse(args[2]);
            double price = double.Parse(args[3]);
            double percantageMarkup = double.Parse(args[4]);
            string storeName = args[5];


            var store = storeList.FirstOrDefault(x => x.Name == storeName);
            if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";
            if (type != "Drink" && type != "Food") return $"Product {type} is invalid!";

            if (type == "Drink")
            {
                Drink drink = new Drink(name, quantity, price, percantageMarkup);
                if (store.GetProduct(name) != null)
                {
                    return $"Product {name} was already delivered to {storeName}!";
                }
                store.ReceiveProduct(drink);
            }
            else if (type == "Food")
            {
                Food food = new Food(name, quantity, price, percantageMarkup);
                if (store.GetProduct(name) != null)
                {
                    return $"Product {name} was already delivered to {storeName}!";
                }
                store.ReceiveProduct(food);
            }


            return $"Product {name} was successfully delivered to {storeName}!";
        }

        public string SellProduct(List<string> args)//done?
        {
            string name = args[0];
            int quanitity = int.Parse(args[1]);
            string storeName = args[2];
            var store = storeList.FirstOrDefault(x => x.Name == storeName);

            if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";
            if (!store.SellProduct(name, quanitity)) return $"Product {name} was already sold out!";

            return $"Product {name} was successfully bought from {storeName}!";
        }

        public string StoreInfo(List<string> args)
        {
            string storeName = args[0];
            var store = storeList.FirstOrDefault(x => x.Name == storeName);

            if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";
            return store.ToString();
            //TODO: Add some logic here …
        }

        public string Shutdown()
        {
            storeList = storeList
                .OrderByDescending(x => x.Revenue)
                .ThenBy(x => x.Name).ToList();

            StringBuilder result = new StringBuilder();
            result.AppendLine($"Stores: {storeList.Count}");
            
            foreach (var store in storeList)
            {
                result.AppendLine(store.ToString());
            }
            result.AppendLine($"System Store Revenues: {storeList.Sum(x=> x.Revenue):F2}BGN");

            return result.ToString().TrimEnd();


            //TODO: Add some logic here …
        }

    }
}
