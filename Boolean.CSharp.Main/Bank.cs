using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Bank
    {
        Dictionary<string, Account> accounts;
        private int accountIterator = 8472352;
        public Bank() 
        {
            this.accounts = new Dictionary<string, Account>();
        }   

        public Dictionary<string, Account> GetAccounts { get { return this.accounts; } }

        public string createAccount(string firstName, string lastName, string type, string branch, double balance)
        {
            string accountNr;
            while (true)
            {
                this.accountIterator++;
                accountNr = this.accountIterator.ToString();
                if (!accounts.ContainsKey(accountNr)) { break; }
            }

            accounts.Add(accountNr, new Account(accountNr, firstName, lastName, type, branch, balance));

            return accounts[accountNr].getAccountNr;
        }

        public Account GetAccount(string accountNr)
        {
            return accounts[accountNr];
        }

        public double GetBalancet(string accountNr)
        {
            return accounts[accountNr].getBalance;
        }

        public double deposit(string accountNr, double amount)
        {
            accounts[accountNr].addTransaction(amount);
            return accounts[accountNr].getBalance;
        }

        public double withdraw(string accountNr, double amount)
        {
            double balance = accounts[accountNr].getBalance;
            if (balance - amount > 0)
            {
                accounts[accountNr].addTransaction(-amount);
            }
            else
            {
                accounts[accountNr].addTransaction(-balance);
            }
            return accounts[accountNr].getBalance;
        }

        public string PrintStatement(string accountNr)
        {
            Statement statement = new Statement(accounts[accountNr]);
            return statement.GetStatement;
        }







    }
}
