using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>();
            int counter = int.Parse(Console.ReadLine());
            Employee worker = new Employee();
            var commandargs = new List<string>();


            while (counter != 0)
            {
                commandargs = Console.ReadLine().Split(' ').ToList();

                worker = new Employee();
                /*                commandargs = "Pesho  120.00  Dev  Development pesho@abv.bg 28";
                */                              //name0  sal1    p2       dep3     em4         ag5 
                worker.Name = commandargs[0];
                worker.Salary = double.Parse(commandargs[1]);
                worker.Position = commandargs[2];
                worker.Department = commandargs[3];

                if (commandargs.Count == 6)
                {
                    worker.Age = int.Parse(commandargs[5]);
                    worker.Email = commandargs[4];

                }
                else if (commandargs.Count == 5)
                {
                    if (commandargs[4].Contains("@"))
                    {
                        worker.Email = commandargs[4];
                    }
                    else
                    {
                        worker.Age = int.Parse(commandargs[4]);
                    }
                }

                workers.Add(worker);

                counter--;
            }
            var workersBySal = workers.OrderBy(x => x.Salary).Reverse().ToList();
            int nSal = workersBySal.Count;
            string highestsal = workersBySal[0].Department;
            var sb = new StringBuilder().Append($"\n Highest Average Salary: {highestsal}\n");
            foreach (var work in workersBySal)
            {
                if (work.Department==highestsal)
                {
                    sb.Append($"{work} \n");
                }
            }
            Console.WriteLine(sb);
        }
    }
    class Employee
    {
        string name;
        double salary;
        string position;
        string department;
        string email = "n/a";
        int age = -1;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Position { get => position; set => position = value; }
        public string Department { get => department; set => department = value; }
        public string Email { get => email; set => email = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"{this.name} {this.salary:F2} {this.email} {this.age}";
        }


    }
}
