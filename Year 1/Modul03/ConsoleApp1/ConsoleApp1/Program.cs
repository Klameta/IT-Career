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
        }
    }

    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }


            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("Name cannot be less than 4 characters");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (age<0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }
    }
}
