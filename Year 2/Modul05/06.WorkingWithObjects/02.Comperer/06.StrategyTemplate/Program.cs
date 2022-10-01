using System;
using System.Collections.Generic;

namespace _06.StrategyTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonNameLenghtComparer personNameLenghtComparer = new PersonNameLenghtComparer();
            SortedSet<Person> peopleNameSort = new SortedSet<Person>(personNameLenghtComparer);

            PersonAgeComperer personAgeComperer = new PersonAgeComperer();
            SortedSet<Person> peopleAgeSort = new SortedSet<Person>(personAgeComperer);

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));
                peopleNameSort.Add(person);
                peopleAgeSort.Add(person);
            }
            Console.WriteLine();

            foreach (var person in peopleNameSort)
            {
                Console.WriteLine(person);
            }

            foreach (var pero in peopleAgeSort)
            {
                Console.WriteLine(pero);
            }
        }
    }
}
