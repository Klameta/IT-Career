using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string[] personInfo = Console.ReadLine().Split(' ').ToArray();
            string[] commandargs = Console.ReadLine().Split(' ').ToArray();

            var member = new Person(personInfo[0], int.Parse(personInfo[1]));
            var acc = new BankAccount();

            for (int i = 0; i < counter; i++)
            {
                acc.Balance = double.Parse(commandargs[0]);
                member.Accounts.Add(acc);

                commandargs = Console.ReadLine().Split(' ').ToArray();
            }
            double result = member.GetBalance();
            Console.WriteLine(result);

        }
    }
    public class Person 
    {
        string name;
        int age;
        List<BankAccount> accounts;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
                age = value;
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
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }
        public double GetBalance()
        {
            var f = new BankAccount();
            double result =0.00;
            foreach (var acc in accounts)
            {
               result += acc.Balance;
            }


            return result;
        }
    }
    public class BankAccount
    {
        double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }
}
