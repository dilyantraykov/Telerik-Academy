using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public const int MonthsWithoutInterestForIndividuals = 6;
        public const int MonthsWithHlafInterestForCompanies = 12;

        public MortgageAccount(Customer initialCustomer, decimal initialBalance, decimal initialInterestRate)
            : base(initialCustomer, initialBalance, initialInterestRate)
        {

        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Client is Company)
            {
                if (numberOfMonths <= 12)
                {
                    return numberOfMonths * (this.Balance * 0.5M);
                }
                else
                {
                    return (12 * (this.Balance * 0.5M)) + ((numberOfMonths - 12) * ((this.InterestRate / 100) * this.Balance));
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return (numberOfMonths - 6) * ((this.InterestRate / 100.0M) * this.Balance);
                }
            }
        }
    }
}
