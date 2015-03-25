using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class DepositAccount : Account, IWithdrawable
    {
        public const decimal MinimumAmountForInterest = 1000;

        public DepositAccount(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
        {
            
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Balance >= MinimumAmountForInterest)
            {
                return numberOfMonths * ((this.InterestRate / 100.0M) * this.Balance);
            }
            else
            {
                return 0.0M;
            }
        }

        public void WithdrawMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount should be positive!");
            }
            if (amount > this.Balance)
            {
                throw new ArgumentException("Not enough money to withdraw from account!");
            }
            this.Balance -= amount;
        }
    }
}
