using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountWFA
{
    public class BankAccount
    {
        public const decimal MinimunAmount = 50;
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount (string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid ();
            Balance = 0;
        }

        public string Deposit (decimal amount)
        {
            if (amount < MinimunAmount || amount > 100000)
            {
                return $"Amount {amount} not permitted!";
            }
            Balance += amount;
            return $"Deposit {amount} Done!";
        }
        public string Withdraw (decimal amount)
        {
            if (amount < MinimunAmount || amount > Balance)
            {
                return $"Withdraw {amount} not permitted!";
            }
            Balance -= amount;
            return $"Withdraw {amount} Done!";
        }
    }
}
