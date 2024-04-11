using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class AdultFamilyMember : FamilyMember
    {
        public AdultFamilyMember(string name, int age, Gender.Sex sex, AdultFamilyMember father, AdultFamilyMember mother, AdultFamilyMember spouse, params FamilyMember[] childrens) 
        {
            Name = name;
            Age = age;
            Sex = sex;
            Father = father;
            Mother = mother;
            Spouse = spouse;
            if (childrens != null)
            {
                Childrens = childrens.ToList();
            }
        }
    }
}
