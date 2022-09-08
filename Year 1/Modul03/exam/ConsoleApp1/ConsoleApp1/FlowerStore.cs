using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class FlowerStore
    {
        string name;
        List<Flower> flowers1 = new List<Flower>();
        public List<Flower> Flowers1
        {
            get
            {
                return flowers1;
            }
            set
            {
                flowers1 = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid flower store name!");
                }
            }
        }
        /* public List<Flower> Flowers1
         {
             get
             {
                 return flowers1;
             }
             set
             {
                 flowers1 = value;
             }
         }*/

        public FlowerStore(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            if (flowers1 == null || flowers1.Count == 0)
            {
                return $"Flower store {this.name} has no available flowers.";
            }
            return $"Flower store {this.name} has {this.flowers1.Count} flower/s:\n{string.Join("\n", flowers1)}";
            /*            foreach (var flowe in this.flowers1)
                        {
                            return flowe.ToString();
                        }*/

        }

        public void AddFlower(Flower flower)
        {
            if (flowers1 == null)
            {
                flowers1 = new List<Flower>();
                flowers1.Add(flower);

            }
            flowers1.Add(flower);


        }
        public bool SellFlower(Flower flower)
        {
            bool asd = false;
            foreach (var flo in Flowers1)
            {
                if (flo == flower)
                {
                    Flowers1.Remove(flo);
                    asd = true;
                }
            }
            return asd;

        }
        public double CalculateTotalPrice()
        {
            double price = 0.00;
            foreach (var flo in flowers1)
            {
                price + = flo.Price;
            }
            return price;
        }
        public Flower GetFlowerWithHighestPrice()
        {

            var modflo = flowers1.OrderBy(x => x.Price);
            Flower modfflo = modflo.First();
            return modfflo;
        }

        public void RenameFlowerStore(string newName)
        {
            this.name = newName;
        }

        public void SellAllFlowers()
        {
            this.flowers1.Clear();
        }

        public Flower GetFlowerWithLowestPrice()
        {
            var modflo = flowers1.OrderBy(x => x.Price);
            Flower modfflo = modflo.First();
            return modfflo;
        }
    }
}
