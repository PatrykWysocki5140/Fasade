using Fasade.Interfaces;
using Fasade.Models;

namespace Fasade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new BankAccount();
            ILoan loan = new BankLoan();
            ISecurity security = new BankSecurity();
            Bank bank = new Bank(account, loan, security);

            bank.GetLoan("12345", 1000.0);
            bank.MakeDeposit("12345", 500.0);
        }
    }
}