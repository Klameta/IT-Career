using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Person_And_His_Money
{
    class BankAccountcs
    {
        private int id;
        private double balance;
        
        public BankAccountcs(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

    }
}
