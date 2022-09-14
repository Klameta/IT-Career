using NUnit.Framework;
using Bank;
namespace banck_TEsts
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AccountInitiallizedWithPositiveValue()
        {
            BankAccount bankAccount = new BankAccount(2_000m);
            Assert.AreEqual(2_000m, bankAccount.Amount);
        }

        [Test]
        public void AccountDeposit()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act
            bankAccount.Deposit(1000);

            //Assert
            Assert.AreEqual(1000, bankAccount.Amount);
        }

        [Test]
        public void AccountWithdraw()
        {
            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.Withdraw(500);
            Assert.AreEqual(500, bankAccount.Amount);
        }

    }
}