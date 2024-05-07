namespace HomeWork7
{
    public class TestClass
    {
        [CustomName("CustomFieldIName")]
        public int I { get; set; }

        [CustomName("CustomFieldSName")]
        public string? S { get; set; }

        [CustomName("CustomFieldDName")]
        public decimal D { get; set; }

        [CustomName("CustomFieldCName")]
        public char[]? C { get; set; }

        public TestClass() { }
        public TestClass(int i)
        {
            I = i;
        }
        public TestClass(int i, string s, decimal d, char[] c) : this(i)
        {
            S = s;
            D = d;
            C = c;
        }
    }
}
