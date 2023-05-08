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
            int counter = int.Parse(Console.ReadLine());
/*            var member = new Person();
*/            var fam = new Family();
            string[] commandargs = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < counter; i++)
            {
                var member = new Person();

                member.Name = commandargs[0];
                member.Age = int.Parse(commandargs[1]);
                commandargs = Console.ReadLine().Split(' ').ToArray();
                fam.AddMember(member) ;
                member=new Person();
            }
            var oldest =fam.GetOldestMember();
            Console.WriteLine(oldest);
        }
    }
    public class Person
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
                if (value.Length<=3)
                {
                    Console.WriteLine("name too short");
                }
                else
                {
                    this.name = value;
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
                if (value<0)
                {
                    Console.WriteLine("age cannot be less than 0");
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
    class Family
    {
        private List<Person> familia;
        public List<Person> Familia
        {
            get
            {
                return familia;
            }
            set
            {
                familia = value;
            }
        }

        public void AddMember(Person member)
        {
            Familia.Add(member);
        }
       public Person GetOldestMember()
        {

            List<Person> PersonByOldest = Familia.OrderBy(x=> x.Age).ToList();
            Person oldestPerson = PersonByOldest[0];

            return oldestPerson;
        }
        public override string ToString()
        {
            return string.Join($"/n", Familia);
        }
    }
}
