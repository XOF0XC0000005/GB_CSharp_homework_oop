using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWork5
{
    public class CalculatorDividedByZeroException : CalculatorException
    {
        public CalculatorDividedByZeroException() { }
        public CalculatorDividedByZeroException(string? message) : base(message) { }
    }
}
