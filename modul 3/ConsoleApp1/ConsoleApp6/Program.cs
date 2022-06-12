using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length <=3)
                {
                    Console.WriteLine("Name cannot be this short");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Age cannot be less than 0");
                }
                else
                {
                    age = value;
                }
            }
        }
        public List<BankAccount> Accounts
        {
            get
            {
                return accounts;
            }
            set
            {
                accounts = value;
            }
        }
        public double GetBalance()
        {
            return this.accounts.Sum();
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
