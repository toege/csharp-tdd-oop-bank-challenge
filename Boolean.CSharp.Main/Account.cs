using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Account
    {
        private string accountNr;
        private string firstName;
        private string lastName;
        private string type;
        private string branch;

        private double balance;
        private List<Transaction> transactions;

        public Account(string accountNr, string firstName, string lastName, string type, string branch, double balance) 
        { 
            this.accountNr = accountNr;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.branch = branch;

            this.balance = balance;
            this.transactions = new List<Transaction>();

        }

        // Getters
        public string getAccountNr  { get { return accountNr; } }

        public string getFirstName  { get { return firstName; } }

        public string getLastName   { get { return lastName; } }
        public string getType       { get { return type; } }
        public string getBranch     { get { return branch; } }
        public double getBalance    { get { return balance; } } 
        public List<Transaction> getTransactions { get { return transactions; } }

        // Setters

        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }  

        public void addTransaction(double amount) 
        { 
            this.transactions.Add(new Transaction(amount)); 
            this.balance += amount;
        }

        public List<Transaction> GetTransactions() { return transactions; }





    }
}
