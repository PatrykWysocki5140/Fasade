using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Interfaces
{
    public interface IAccount
    {
        bool HasSufficientFunds(string accountNumber, double amount);
        void MakeDeposit(double amount);
    }
}
