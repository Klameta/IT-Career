using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new BankAccount();
            person.Deposit(15);
            person.Withdraw(10);
            Console.WriteLine(person);

        }
    }
    class BankAccount
    {
        int id;
        double balance;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Invalid command");
                }
                else
                {
                    this.id = value;
                }
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance<0)
                {
                    throw new ArgumentException("Invalid command");
                }
            }
        }
        public void Deposit(double amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Invalid command");
            }
            else
            {
                this.balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Invalid command");
            }
            else if (amount>this.balance)
            {
                throw new ArgumentException("Not enough money");
            }
            else
            {
                this.balance -= amount;
            }
        }
        public override string ToString()
        {
            return $"Account ID{id} has {balance}$";
        }
    }
}
