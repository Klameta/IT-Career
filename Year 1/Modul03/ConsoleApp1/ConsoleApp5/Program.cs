using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> client = new Dictionary<int, BankAccount>();
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();

            while (commandArgs[0] != "End")
            {

                switch (commandArgs[0])
                {
                    case "Create":
                        int id = int.Parse(commandArgs[1]);
                        if (client.ContainsKey(id))
                        {
                            Console.WriteLine("Account already exists!");
                        }
                        else
                        {
                            var acc = new BankAccount();
                            acc.Id = id;
                            client.Add(id, acc);
                        }
                        break;
                    case "Deposit":
                        id = int.Parse(commandArgs[1]);
                        double amount = int.Parse(commandArgs[2]);
                        if (!client.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            client[id].Deposit(amount);
                        }
                        break;
                    case "Withdraw":
                        id = int.Parse(commandArgs[1]);
                        amount = int.Parse(commandArgs[2]);
                        if (!client.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            client[id].Withdraw(amount);
                        }
                        break;
                    case "Print":
                        id = int.Parse(commandArgs[1]);
                        if (!client.ContainsKey(id))
                        {
                            Console.WriteLine("Account does not exist");
                        }
                        else
                        {
                            id = int.Parse(commandArgs[1]);
                            Console.WriteLine(client[id].ToString());
                        }
                        break;

                }
                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }
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
