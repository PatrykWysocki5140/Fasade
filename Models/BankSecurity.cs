using Fasade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Models
{
    public class BankSecurity : ISecurity
    {
        public bool VerifyAccount(string accountNumber)
        {
            // Sprawdź konto i zwróć true, jeśli jest bezpieczne
            return true;
        }
    }
 }
