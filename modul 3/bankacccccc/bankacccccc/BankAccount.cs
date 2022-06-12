using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacccccc
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int Id { get => id; set => id = value; }
        public double Balance { get => balance; private set => balance = value; }

        public void Deposit(double amount)
        {
            if (amount<=0)
            {
                Console.WriteLine("amount must be a positive number");
            }
            else
            {
                balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be a positive number");
            }
            else if (amount>balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account {id} and balance {balance:F2}";
        }
    }
}
