using System.Collections.Generic;
using System.Linq;

namespace _04_Test_Client
{
     class Person
     {
        private string name;        
        private int age;
        private List<BankAccount> accs = new List<BankAccount>();


        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        internal List<BankAccount> Accs { get => accs; set => accs = value; }

        public double GetBalance()
        {
            return accs.Sum(x => x.Balance);


        }
    }
}