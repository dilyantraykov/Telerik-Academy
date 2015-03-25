using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public const int MonthsWithouInterestForIndividuals = 3;
        public const int MonthsWithouInterestForCompanies = 2;

        public LoanAccount(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
        {

        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths <= 0)
            {
                throw new ArgumentOutOfRangeException("Number of months should be positive!");
            }
            if (this.Client is Individual)
            {
                numberOfMonths = Math.Max(0, numberOfMonths - 3);
            }
            else
            {
                numberOfMonths = Math.Max(0, numberOfMonths - 2);
            }

            return numberOfMonths * ((this.InterestRate / 100.0M) * this.Balance);
        }
    }
}
