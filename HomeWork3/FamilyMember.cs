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
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember? Spouse { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public FamilyMember[]? Childrens { get; set; }

        public void PrintName() => Console.WriteLine(Name);
        public void PrintAge() => Console.WriteLine(Age);
        public void PrintParents()
        {
            Console.WriteLine($"Мама:\nИмя:{this.Mother.Name}\nВозраст:{this.Mother.Age}\nПол:{this.Mother.Sex}");
            Console.WriteLine($"Папа:\nИмя:{this.Father.Name}\nВозраст:{this.Father.Age}\nПол:{this.Father.Sex}");
        }
        public void PrintChildrens()
        {
            if (Childrens == null )
            {
                Console.WriteLine("Детей нет!");
                return;
            }

            for (int i = 0; i < Childrens.Length; i++)
            {
                Console.WriteLine($"{i}. Имя:{this.Childrens[i].Name} Возраст:{this.Childrens[i].Age} Пол:{this.Childrens[i].Sex}");
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
