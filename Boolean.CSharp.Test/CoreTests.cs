using Boolean.CSharp.Main;
using NUnit.Framework;

namespace Boolean.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private Core _core;

        public CoreTests()
        {
            _core = new Core();

        }

        [Test]
        public void TestAddNewAddcounts()
        {
            Bank bank = new Bank();
            string tomBomCurrAccNr = bank.createAccount("Tom", "Bombadill", "Current Account", "Oslo", 2000);
            string tomBomSaveAccNr = bank.createAccount("Tom", "Bombadill", "Savings Account", "Oslo", 365589);

            string sauronCurrAccNr = bank.createAccount("Sauron", "", "Current Account", "Oslo", 46437928);
            string sauronSaveAccNr = bank.createAccount("Sauron", "", "Savings Account", "Oslo", 948792109274);

            Assert.That(bank.GetAccount(tomBomCurrAccNr).getAccountNr, Is.EqualTo(tomBomCurrAccNr));
            Assert.That(bank.GetAccount(tomBomSaveAccNr).getAccountNr, Is.EqualTo(tomBomSaveAccNr));
            Assert.That(bank.GetAccount(sauronCurrAccNr).getAccountNr, Is.EqualTo(sauronCurrAccNr));
            Assert.That(bank.GetAccount(sauronSaveAccNr).getAccountNr, Is.EqualTo(sauronSaveAccNr));

            Assert.That(bank.GetAccounts.Count, Is.EqualTo(4));
        }

        [Test]
        public void TestDepositWithdrawAndPrintStatement()
        {
            Bank bank = new Bank();
            string sauronCurrAccNr = bank.createAccount("Sauron", "", "Current Account", "Oslo", 5000000); //5M
            Assert.That(bank.GetAccounts.Count, Is.EqualTo(1));

            Assert.That(bank.deposit(sauronCurrAccNr, 100000), Is.EqualTo(5100000));
            Assert.That(bank.deposit(sauronCurrAccNr, 4000000), Is.EqualTo(9100000));
            Assert.That(bank.withdraw(sauronCurrAccNr, 5000000), Is.EqualTo(4100000));
            Assert.That(bank.withdraw(sauronCurrAccNr, 5000000), Is.EqualTo(0)); // withdraw more than the account holds, withraw remainder, balance is 0
            Assert.That(bank.deposit(sauronCurrAccNr, 987654), Is.EqualTo(987654));

            string newStatement = bank.PrintStatement(sauronCurrAccNr);

            // Test the amount of lines in the statement
            Assert.That(newStatement.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None).Length, Is.EqualTo(12));
        }
    }
}