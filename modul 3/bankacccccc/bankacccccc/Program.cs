using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacccccc
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            string command = "";

            while((command = Console.ReadLine()) != "End")
            {
                string[] commandArg = command.Split(' ');

                if (commandArg[0] == "Create")
                {
                    int id = int.Parse(commandArg[1]);
 
                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Accounr already exists");
                    }
                    else
                    {
                        BankAccount account = new BankAccount();
                        account.Id = id;
                        accounts.Add(id, account);
                    }
                }
                else if (commandArg[0] == "Deposit")
                {
                    int id = int.Parse(commandArg[1]);
                    double amount = double.Parse(commandArg[2]);

                    if (accounts.ContainsKey(id))
                    {
                        accounts[id].Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine($"Account with id {id} does not exists");
                    }

                }
                else if (commandArg[0] == "Withdraw")
                {
                    int id = int.Parse(commandArg[1]);
                    double amount = double.Parse(commandArg[2]);

                    if (accounts.ContainsKey(id))
                    {
                        accounts[id].Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine($"Account with id {id} does not exists");
                    }
                }
                else if (commandArg[0] =="Print")
                {
                    int id = int.Parse(commandArg[1]);

                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine(accounts[id]);
                    }
                    else
                    {
                        Console.WriteLine($"Account with id {id} does not exists");
                    }
                }
            }

        }

    }
}
