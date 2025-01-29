using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Boolean.CSharp.Main
{
    public class Transaction
    {
        private string time;
        private string amount;
        DateTime currentDateTime = DateTime.Now;

        public Transaction(double amount) {
            this.time = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            this.amount = amount.ToString();
        }

        // Getters and setters
        public string GetAmount() { return this.amount; }
        public string GetTime() { return this.time; } 
    
    }    
}

