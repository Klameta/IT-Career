using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _07.LogicForEquality
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person)) return false;

            Person other = (Person)obj;
            return Name == other.Name && Age == other.Age;
        }

        public int CompareTo([AllowNull] Person other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            return this.Age.CompareTo(other.Age);
        }

        public override int GetHashCode()
        {
            return Age*Name.GetHashCode();
        }

    }
}
