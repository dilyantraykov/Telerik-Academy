using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class TestBank
    {
        static void Main()
        {
            var bank = new Bank();
            var rand = new Random();

            bank.AddAccount(new MortgageAccount(new Individual("Slim Shady"), 12000.0M, 3.3M));
            bank.AddAccount(new DepositAccount(new Company("Telerik Academy"), 75000.0M, 1.2M));
            bank.AddAccount(new LoanAccount(new Company("Telenor"), 100000.0M, 2.2M));
            bank.AddAccount(new LoanAccount(new Individual("Doctor Dre"), 12900.0M, 2.4M));
            foreach (var account in bank.GetAccounts())
            {
                var months = rand.Next(5, 13);
                Console.WriteLine("{0}'s interest amount after {1} months: {2:F2}", account.Client.Name, months, account.CalculateInterest(months));
            }
        }
    }
}
