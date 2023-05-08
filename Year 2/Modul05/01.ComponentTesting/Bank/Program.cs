    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();

            string[] comandArgs = Console.ReadLine().Split();
            //Deposit Peter 50
            //Deposit Peter 100
            //Withdraw Peter 200
            //Withdraw Peter 10
            //CheckStats
            while (comandArgs[0]!="End")
            {
                switch (comandArgs[0])
                {
                    case "Deposit":
                        string name = comandArgs[1];
                        decimal amount = decimal.Parse(comandArgs[2]);
                        break;
                    case "Withdraw":

                        break;
                    case "CheckStats":

                        break;
                }
            }


        }
        static void Deposit(string name, decimal depositedMoney, List<BankAccount> bankAccounts)
        {
            foreach (var bankacc in bankAccounts)
            {
            }
        }
        static void Withdraw(string name, decimal moneyToWithdraw, LinkedList<BankAccount> bankAccounts)
        {
            foreach (var bankacc in bankAccounts)
            {
            }
        }
    }
}
