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
            var member = new Person();
            string[] commandargs = Console.ReadLine().Split(' ').ToArray();
            List<Person> people = new List<Person>();
            List<Person> oldPeople = new List<Person>();
            for (int i = 0; i < counter; i++)
            {
                member.Name = commandargs[0];
                member.Age = int.Parse(commandargs[1]);
                people.Add(member);
                member = new Person();
                commandargs = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var per in people)
            {
                if (per.Age>30)
                {
                    oldPeople.Add(per);
                }
            }
            Console.WriteLine(string.Join($"\n", oldPeople));
        }
    }
    class Person
    {
        string name;
        int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name cannot be this short");
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
                if (age < 0)
                {
                    throw new ArgumentException("age cannot be a negative number");
                }
                else
                {
                    age = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{this.name} - {this.age}";
        }


    }
}
