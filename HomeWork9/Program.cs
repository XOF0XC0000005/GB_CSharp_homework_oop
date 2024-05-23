namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonFile =
            """
                {"Name":"Lev","Surname":"Reva","Sex":"Male","Age":28,"Wanted":["Proper teaching","Good job","Be happy"]}
            """;

            JsonToXmlConverter.Start(jsonFile);
        }
    }
}
