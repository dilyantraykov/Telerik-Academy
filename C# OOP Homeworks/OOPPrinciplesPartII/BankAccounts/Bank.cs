using System;
using System.Collections.Generic;

namespace BankAccounts
{
    public class Bank
    {
        private IList<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public IList<Account> GetAccounts()
        {
            var result = new List<Account>(this.accounts);
            return result;
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }
    }
}
