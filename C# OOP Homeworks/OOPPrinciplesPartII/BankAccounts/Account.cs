using System;

namespace BankAccounts
{
    public class Account : IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Client = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public Customer Client
        {
            get { return this.customer; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }
        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
        }

        public void DepositMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive!");
            }
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int numberOfMonths)
        {
            return numberOfMonths * this.interestRate;
        }
    }
}
