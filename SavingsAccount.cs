using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountWFA
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount (string owner, decimal interestRate) : base (owner + $" ({interestRate}%)")
        {
            InterestRate = interestRate; 
        }

        //public override string Deposit(decimal amount)
        //{            
        //    return base.Deposit(amount + amount * InterestRate / 100);            
        //}
        public override string Deposit (decimal amount)
        {
            if (amount < MinimunAmount || amount > 100000)
            {
                return $"Amount {amount} not permitted!";
            }
            Balance += amount + amount * InterestRate / 100;
            return $"Deposit {amount} Done!";
        }
    }
}
