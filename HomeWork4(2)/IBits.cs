using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal interface IBits
    {
        public bool GetBit(int i);
        public void SetBit(int i, bool val);
    }
}
