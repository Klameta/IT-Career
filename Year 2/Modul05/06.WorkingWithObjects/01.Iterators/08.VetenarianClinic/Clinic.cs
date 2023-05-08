using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _08.VetenarianClinic
{
    internal class Clinic : IEnumerable<Animal>
    {
        private int rooms;

        readonly IReadOnlyList<Animal> animals;


        public string Name { get; private set; }

        public int Rooms
        {
            get { return rooms; }
            private set
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine("Invalid Operation!");
                    return;
                }
                rooms = value;
            }
        }

        public Clinic(string name, int rooms)
        {
            Name = name;
            Rooms = rooms;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            int index = animals.Count +1/2;
            yield return animals[index];
            int addingSubtracting = 1;
            while (index-addingSubtracting>1)
            {
                yield return animals[index-addingSubtracting];
                yield return animals[index+ addingSubtracting];
                addingSubtracting++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
