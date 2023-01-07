using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade.Interfaces
{
    public interface ISecurity
    {
        bool VerifyAccount(string accountNumber);
    }
}
