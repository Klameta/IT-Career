using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Family familia = new Family();
            int counter = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < counter; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                person.Name = commandArgs[0];
                person.Age = int.Parse(commandArgs[1]);
                familia.Members.Add(person);
                person = new Person();
            }

            familia.Members = familia.Members.OrderBy(x => x.Name).ToList();
            /*foreach (var member in familia.Members)
            {
                Console.WriteLine(string.Join(", ", member.ToString()));
            }*/
            familia.Print(familia.Members);
        }
    }
    class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("age must be more than 0");
                }
                else
                {
                    age = value;
                }
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
                if (value.Length <= 3)
                {
                    Console.WriteLine("Name must be more than 3 chars");
                }
                else
                {
                    name = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{this.name} - {this.age}";
        }

    }
    class Family
    {
        private List<Person> members = new List<Person>();

        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void Print(List<Person> person)
        {
            foreach (var member in this.Members)
            {
                Console.WriteLine(string.Join(", ", member.ToString()));
            }
        }
    }
}
