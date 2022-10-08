using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Birthday
{
    class Pet : IBirthable
    {
        private string birthday;
        private string name;

        public string Birthday { get => birthday; private set => birthday = value; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Pet(string birthday, string name)
        {
            Birthday = birthday;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Birthday}"; 
        }
    }
}
