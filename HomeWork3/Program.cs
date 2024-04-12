namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdultFamilyMember familyMember3 = new AdultFamilyMember("Денис", 69, Gender.Sex.Male, null, null, null, new List<FamilyMember>());
            AdultFamilyMember familyMember4 = new AdultFamilyMember("Анастасия", 69, Gender.Sex.Female, null, null, familyMember3, new List<FamilyMember>());
            AdultFamilyMember familyMember7 = new AdultFamilyMember("Антон", 69, Gender.Sex.Male, null, null, null, new List<FamilyMember>());
            AdultFamilyMember familyMember8 = new AdultFamilyMember("Алла", 69, Gender.Sex.Female, null, null, familyMember7, new List<FamilyMember>());
            AdultFamilyMember familyMember1 = new AdultFamilyMember("Алексей", 38, Gender.Sex.Male, familyMember3, familyMember4, null, new List<FamilyMember>());
            AdultFamilyMember familyMember2 = new AdultFamilyMember("Мария", 38, Gender.Sex.Female, familyMember7, familyMember8, familyMember1, new List<FamilyMember>());
            AdultFamilyMember familyMember5 = new AdultFamilyMember("Лев", 17, Gender.Sex.Male, familyMember1, familyMember2, null, new List<FamilyMember>());
            AdultFamilyMember familyMember6 = new AdultFamilyMember("Айна", 16, Gender.Sex.Female, familyMember1, familyMember2, null, new List<FamilyMember>());

            familyMember1.AddChildren(familyMember5);
            familyMember1.AddChildren(familyMember6);
            familyMember2.AddChildren(familyMember5);
            familyMember2.AddChildren(familyMember6);
            familyMember3.AddChildren(familyMember1);
            familyMember4.AddChildren(familyMember1);
            familyMember7.AddChildren(familyMember2);
            familyMember8.AddChildren(familyMember2);

            familyMember3.Spouse = familyMember4;
            familyMember7.Spouse = familyMember8;
            familyMember1.Spouse = familyMember2;

            familyMember1.PrintCloseRelatives();
            Console.ReadLine();
        }

    }
}
