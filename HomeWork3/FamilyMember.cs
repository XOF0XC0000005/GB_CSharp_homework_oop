namespace HomeWork3
{
    internal abstract class FamilyMember
    {
        public string Name { get; set; }
        public FamilyMember? Mother { get; set; }
        public FamilyMember? Father { get; set; }
        public FamilyMember? Spouse { get; set; }
        public int Age { get; set; }
        public Gender.Sex Sex { get; set; }
        public List<FamilyMember>? Childrens { get; set; }

        public void PrintName() => Console.WriteLine(Name);
        public void PrintAge() => Console.WriteLine(Age);
        public void PrintParents()
        {
            if (Mother != null)
            {
                Console.WriteLine($"Мама: Имя:{Mother.Name} Возраст:{Mother.Age} Пол:{Mother.Sex}");
            }
            else
            {
                Console.WriteLine("Нет информации по маме");
            }

            if (Father != null)
            {
                Console.WriteLine($"Папа: Имя:{Father.Name} Возраст:{Father.Age} Пол:{Father.Sex}");
            }
            else
            {
                Console.WriteLine("Нет информации по папе");
            }

        }

        public void AddChildren(AdultFamilyMember children)
        {
            if (children != null)
            {
                Childrens.Add(children);
            }
        }
        public void PrintChildrens()
        {
            if (Childrens == null)
            {
                Console.WriteLine("Нет информации по детям!");
                return;
            }

            for (int i = 0; i < Childrens.Count; i++)
            {
                Console.WriteLine($"{i}. Имя:{Childrens[i].Name} Возраст:{Childrens[i].Age} Пол:{Childrens[i].Sex}");
            }
        }

        public void PrintSpouse()
        {
            if (Spouse == null)
            {
                Console.WriteLine("Нет информации по супругу!");
                return;
            }

            Console.WriteLine($"Супруг: Имя:{Spouse.Name} Возраст:{Spouse.Age} Пол:{Spouse.Sex}");
        }

        public void PrintCloseRelatives()
        {
            PrintSpouse();
            Console.WriteLine($"Родители: ");
            PrintParents();
            Console.WriteLine($"Дети: ");
            PrintChildrens();
        }
    }
}
