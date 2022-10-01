using System;
using System.Collections.Generic;

namespace _07.LogicForEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            PersonComperer personComperer = new PersonComperer();
            SortedSet<Person> peopleSet = new SortedSet<Person>(personComperer);
            HashSet<Person> peopleHash = new HashSet<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));

                peopleSet.Add(person);
                peopleHash.Add(person);
            }

            Console.WriteLine(peopleSet.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}
