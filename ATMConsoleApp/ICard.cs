using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    interface ICard
    {
        string GetNumber();
        string GetValidationDate();
        int GetThreeDigitCode();
    }
}
