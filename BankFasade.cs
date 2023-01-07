using Fasade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class Bank : IAccount, ILoan, ISecurity
    {
        private IAccount _bankAccount;
        private ILoan _bankLoan;
        private ISecurity _bankSecurity;

        public Bank(IAccount bankAccount, ILoan bankLoan, ISecurity bankSecurity)
        {
            _bankAccount = bankAccount;
            _bankLoan = bankLoan;
            _bankSecurity = bankSecurity;
        }

        public bool HasSufficientFunds(string accountNumber, double amount)
        {
            return _bankAccount.HasSufficientFunds(accountNumber, amount);
        }

        public void MakeDeposit(double amount)
        {
            _bankAccount.MakeDeposit(amount);
        }

        public bool HasGoodCredit(string accountNumber)
        {
            return _bankLoan.HasGoodCredit(accountNumber);
        }

        public void GetLoan(double loanAmount)
        {
            _bankLoan.GetLoan(loanAmount);
        }

        public bool VerifyAccount(string accountNumber)
        {
            return _bankSecurity.VerifyAccount(accountNumber);
        }

        public void GetLoan(string accountNumber, double loanAmount)
        {
            if (VerifyAccount(accountNumber) &&
               HasGoodCredit(accountNumber) &&
               HasSufficientFunds(accountNumber, loanAmount))
            {
                GetLoan(loanAmount);
            }
        }

        public void MakeDeposit(string accountNumber, double amount)
        {
            if (VerifyAccount(accountNumber) &&
               HasSufficientFunds(accountNumber, amount))
            {
                MakeDeposit(amount);
            }
        }
    }
}
