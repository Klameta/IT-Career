using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Person
    {
        private string name;
        private static int count = 0;

        public Person(string name)
        {
            Name = name;
            count++;
        }

        public static int Count
        {
            get { return count; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
