using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Person_And_His_Money
{
    class Person
    {
        private string name;
        private int age;
        public List<BankAccountcs> bankAccountcs = new List<BankAccountcs>();

        public double GetBalance()
        {
            return bankAccountcs.Sum(x => x.Balance);
        }
            
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
