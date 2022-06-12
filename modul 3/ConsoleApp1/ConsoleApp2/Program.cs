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
            List<Person> family = new List<Person>();
            for (int i = 0; i < counter; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
                family.Add
                    (
                     new Person()
                     {
                         Name = commandArgs[0],
                         Age = int.Parse(commandArgs[1])
                     }
                    );
            }
            foreach (var person in family)
            {
                family = family.OrderBy(x => x.Name).ToList();
            }
            foreach (var person in family)
            {
                if (person.Age>=30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");

                }
            }
        }
    }
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }
                else
                {
                    age = value;
                }
            }

        }
        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
        }
    }
    class Family
    {
        private List<Person> people = new List<Person>();
        public List<Person> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
            }
        }
        public void Print()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"Name {person.Name} Age {person.Age}");
            }
        }
    }
}
