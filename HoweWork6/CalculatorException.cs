using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWork5
{
    public class CalculatorException : Exception
    {
        public CalculatorException() { }
        public CalculatorException(string? message) : base(message) { }
    }
}
