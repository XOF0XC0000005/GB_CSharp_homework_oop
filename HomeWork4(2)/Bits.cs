namespace Seminar1
{
    internal class Bits : IBits
    {
        public Bits(byte b) 
        {
            Value = b;
            SizeOfValue = sizeof(byte) * 8;
        }

        public Bits(long b)
        {
            Value = b;
            SizeOfValue = sizeof(long) * 8;

        }

        public Bits(short b)
        {
            Value = b;
            SizeOfValue = sizeof(short) * 8;

        }

        public Bits(int b)
        {
            Value = b;
            SizeOfValue = sizeof(int) * 8;

        }


        public long Value { get; private set; } = 0;
        public int SizeOfValue { get; set; }

        public static implicit operator Bits(byte b) => new Bits(b);
        public static implicit operator Bits(long b) => new Bits(b);
        public static implicit operator Bits(int b) => new Bits(b);


        public bool GetBit(int i)
        {
            if (i > SizeOfValue || i < 0)
                return false;
            return ((Value >> i) & 1) == 1;
        }

        public void SetBit(int i, bool val)
        {
            if (i > SizeOfValue || i < 0)
                if (val)
                    Value = (byte)(Value | (1 << i));
                else
                {
                    var mask = (byte)(1 << i);
                    mask = (byte)(0xff ^ mask);
                    Value &= (byte)(Value & mask);
                }
        }
    }
}
