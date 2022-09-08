using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02_bank_acc
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive!");
            }
            else
            { 
                balance += amount;
            }
        }

       public void Withdraw(double amount)
        {
            if (amount<=0)
            {
                Console.WriteLine("Amount must be a positive number!");
            }
            else if(balance-amount<0)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                balance -= amount;
            }
        }
    }
}