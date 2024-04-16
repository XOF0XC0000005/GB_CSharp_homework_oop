using System.Security.Cryptography;

namespace Seminar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int someInt = 1123123123;
            Bits bitsInt = someInt;

            byte someByte = 11;
            Bits bitsByte = someByte;

            long someLong = 1123123123;
            Bits bitsLong = someLong;
        }
    }
}