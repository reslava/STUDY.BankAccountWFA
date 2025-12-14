using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountWFA
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = balance;
        }
    }
}
