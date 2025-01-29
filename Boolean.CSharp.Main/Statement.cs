using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Statement
    {
        private string statement;
        public Statement(Account account) 
        {
            statement =
            $"{account.getBranch}\n" +
            $"{account.getType}\n" +
            $"Account Nr: {account.getAccountNr}\n" +
            $"Name: {account.getLastName}, {account.getFirstName}\n" +
            $"Ballance: {account.getBalance}$\n" +
            $"Transactions:\n" ; 
            
            foreach (var transaction in account.getTransactions)
            {
                string transactionLine = $"Time: {transaction.GetTime()}      {transaction.GetAmount()}$\n";
                statement += transactionLine;
            }
        }

        public string GetStatement { get { return statement; } }


    }
}
