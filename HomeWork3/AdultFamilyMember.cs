namespace HomeWork3
{
    internal class AdultFamilyMember : FamilyMember
    {
        public AdultFamilyMember(string name, int age, Gender.Sex sex, AdultFamilyMember father, AdultFamilyMember mother, AdultFamilyMember spouse, List<FamilyMember> childrens)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Father = father;
            Mother = mother;
            Spouse = spouse;
            if (childrens != null)
            {
                Childrens = childrens;
            }
        }
    }
}
