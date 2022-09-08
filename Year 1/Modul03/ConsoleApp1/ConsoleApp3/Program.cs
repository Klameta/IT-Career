using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person(10, "pesho");
            firstPerson.IntroduceYourSelf();

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
                if (value<0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
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
                if (value.Length<=3)
                {
                    throw new ArgumentException("Name cannot be this short!");
                }
                else
                {
                    name = value;
                }
            }
        }
       public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
        public void IntroduceYourSelf()
        {
            Console.WriteLine($"Hello I am {this.Name} and I am {this.Age} years old");
        }
    }
}
