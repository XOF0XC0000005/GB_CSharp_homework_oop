using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

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
                Console.WriteLine($"Мама:\nИмя:{Mother.Name}\nВозраст:{Mother.Age}\nПол:{Mother.Sex}");
            }
            else
            {
                Console.WriteLine("Нет мамы");
            }
            
            if (Father != null)
            {
                Console.WriteLine($"Папа:\nИмя:{Father.Name}\nВозраст:{Father.Age}\nПол:{Father.Sex}");
            }
            else
            {
                Console.WriteLine("Нет папы");
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
            if (Childrens == null )
            {
                Console.WriteLine("Детей нет!");
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
                Console.WriteLine("Супруга нет!");
                return;
            }

            Console.WriteLine($"Супруг: Имя:{Spouse.Name}\nВозраст:{Spouse.Age}\nПол:{Spouse.Sex}");
        }

        public void PrintCloseRelatives()
        {
            Console.WriteLine("Супруг: ");
            PrintSpouse();
            Console.WriteLine($"Родители: ");
            PrintParents();
            Console.WriteLine($"Дети: ");
            PrintChildrens();
        }
    }
}
