using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    class Employee : Person
    {
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public Employee(int age, string name, string company) : base(age, name)
        {
            Company = company;
        }
    }
}
