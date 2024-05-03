using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoweWork5
{
    public class CalculateOperationCauseOverflowException : CalculatorException
    {
        public CalculateOperationCauseOverflowException() { }
        public CalculateOperationCauseOverflowException(string? message) : base(message) { }
    }
}
