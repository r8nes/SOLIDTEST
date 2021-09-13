using System;
using System.Collections.Generic;

namespace SOLID
{
    public partial class Vampire
    {
        private string _name;
        private int _age;

        public Vampire(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge() {
            return _age;
        }
    }

    public static class VampireInfo
    {
        public static void Check(Vampire vampire)
        {
            Console.WriteLine($"Vampire name is {vampire.GetName()}. It's {vampire.GetAge()} age old\n");
        }

        public static void Check(List<Vampire> vampires) {
            foreach (Vampire vampire in vampires)
            {
                Console.WriteLine($"Vampire name is {vampire.GetName()}. It's {vampire.GetAge()} age old\n");
            }
        }
    }
}


