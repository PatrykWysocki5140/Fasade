using Fasade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Models
{
    public class BankAccount : IAccount
    {
        public bool HasSufficientFunds(string accountNumber, double amount)
        {
            // Pobierz saldo konta i sprawdź, czy jest wystarczające
            return true;
        }

        public void MakeDeposit(double amount)
        {
            // Zrób wpłatę na konto
        }
    }
}
