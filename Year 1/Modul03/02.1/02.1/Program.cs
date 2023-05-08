using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Balance = 23;
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
                    Console.WriteLine("Id cannot be less than 0!");
                }
                else
                {
                    id = value;
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
                if (value < 0)
                {
                    Console.WriteLine("Balance canno be less than 0");
                }
                else
                {
                    balance = value;
                }
            }
        }
    }

}
