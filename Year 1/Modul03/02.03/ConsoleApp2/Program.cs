using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            var listCar = new List<Car>();
            var car = new Car();
            var mod = new Model();
            var l = new Load();
            var t = new Tire();
            var tireList = new List<Tire>();
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < counter; i++)
            {
                {
                    mod.ModelOfCar = commandArgs[0];
                    mod.Speed = int.Parse(commandArgs[1]);
                    mod.Power = int.Parse(commandArgs[2]);
                    car.ModelOfCar = mod;
                }//model
                {
                    l.LoadWeight = int.Parse(commandArgs[3]);
                    l.LoadType = commandArgs[4];
                    car.LoadCar = l;
                }//load
                
                {
                    int n = 0;
                    for (int f = 0; f < 4; f++)
                    {
                        t.TirePressure = double.Parse(commandArgs[5+n]);
                        t.TireAge = int.Parse(commandArgs[6+n]);
                        tireList.Add(t);
                        t = new Tire();
                        n += 2;
                    }
                    car.Tires = tireList;
                    tireList = new List<Tire>();
                }//tires

                if (i<3)
                {
                    commandArgs = Console.ReadLine().Split(' ').ToArray();

                }
                listCar.Add(car);
                car = new Car();
                mod = new Model();
                l = new Load();

            }
            string fra = Console.ReadLine();
            int cofcar = 0;
            foreach (var carr in listCar)
            {
                switch (fra)
                {
                    case "fragile":
                        if (carr.LoadCar.LoadType == "fragile")
                        {
                            foreach (var tire in carr.Tires)
                            {
                                if (tire.TirePressure < 1)
                                {
                                    cofcar++;
                                }
                            }
                            if (cofcar==4)
                            {
                                Console.WriteLine(carr.ModelOfCar.ModelOfCar);
                            }
                        }

                        break;
                    case "flamable":
                        if (carr.LoadCar.LoadType == "flamable" && carr.ModelOfCar.Power > 250)
                        {
                            Console.WriteLine(carr.ModelOfCar.ModelOfCar);
                        }
                        break;

                }
            }
        }
    }
    public class Car
    {
        List<Tire> tires;
        Model modelOfCar;
        Load loadCar;

        public Load LoadCar { get => loadCar; set => loadCar = value; }
        public Model ModelOfCar { get => modelOfCar; set => modelOfCar = value; }
        public List<Tire> Tires { get => tires; set => tires = value; }
        public override string ToString()
        {
            return $"{this.loadCar} - {this.modelOfCar} - {this.tires}";
        }
    }
    public class Model
    {
        int speed;
        int power;
        string model;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public string ModelOfCar { get => model; set => model = value; }

        public override string ToString()
        {
            return $"{this.speed} - {this.power}";
        }
    }
    public class Load
    {
        int loadWeight;
        string loadType;
        public int LoadWeight
        {
            get
            {
                return loadWeight;
            }
            set
            {
                loadWeight = value;
            }
        }
        public string LoadType
        {
            get
            {
                return loadType;
            }
            set
            {
                loadType = value;
            }
        }
        public override string ToString()
        {
            return $"{this.loadType} - {this.loadWeight}";
        }
    }
    public class Tire
    {
        double tirePressure;
        int tireAge;
        public double TirePressure
        {
            get
            {
                return tirePressure;
            }
            set
            {
                tirePressure = value;
            }
        }
        public int TireAge
        {
            get
            {
                return tireAge;
            }
            set
            {
                tireAge = value;
            }
        }
        public override string ToString()
        {
            return $"{this.tireAge} - {this.tirePressure}";
        }

    }
}
