using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {


        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public BankAccount()
        {

        }
        public BankAccount( decimal amount)
        {
            this.amount = amount;
        }
        public override string ToString()
        {
            return $"The bank acount has {this.amount:F2}$.";
        }
        public void Deposit(int money)
        {
            this.amount += money;
        }
        public void Withdraw(int money)
        {
            if (this.amount< money)
            {
                throw new Exception();
            }
            else
            {
                amount -= money;
            }
        }
    }
}
