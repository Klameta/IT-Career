using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 5;
            acc.Deposit(30);
            acc.Withdraw(20);
            Console.WriteLine(acc.ToString());
        }
    }
    class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id canno be a negative number");
                }
                else
                {
                    id = value;
                }
            }
        }
        public double Balance
        {
            private get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be a negative number!");
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposited amount must be a positive number");
            }
            else
            {
                this.balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be a positive number");
            }
            else if (amount > this.balance)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                this.balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"BankAccount with id {this.id} has {this.balance:F2} money";
        }
    }

}
