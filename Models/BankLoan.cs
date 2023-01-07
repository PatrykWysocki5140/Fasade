using Fasade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Models
{
    public class BankLoan : ILoan
    {
        public bool HasGoodCredit(string accountNumber)
        {
            // Sprawdź historię kredytową i zwróć true, jeśli jest dobra
            return true;
        }

        public void GetLoan(double loanAmount)
        {
            // Udziel pożyczki
        }
    }
}
