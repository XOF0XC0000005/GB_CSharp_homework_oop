using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWork5
{
    internal class CalculatorNegativeNumberException : CalculatorException
    {
        public CalculatorNegativeNumberException() { }
        public CalculatorNegativeNumberException(string? message) : base(message) { }
    }
}
