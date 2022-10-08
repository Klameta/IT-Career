using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    class Student : Person
    {
        private string school;          

        public Student(int age, string name, string school) : base(age, name)
        {
            School = school;
        }

        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {School}";
        }
    }
}
