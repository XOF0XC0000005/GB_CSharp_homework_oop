namespace HomeWork9
{
    public record class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public List<string> Wanted { get; set; }
    }
}
