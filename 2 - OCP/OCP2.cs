using System;
using SOLID.SRP;

namespace SOLID.OCP2
{ 
        interface IForm
        {
            public void ChangeForm(Vampire vampire) {}
        }

        public class BatForm2 : IForm
        {
            public void ChangeForm(Vampire vampire)
            {
                Console.WriteLine($"{vampire.GetName()} is trying change form. Batmanpire appeared.\n");
            }
        }

        public class NosferatuForm2 : IForm
        {
            public void ChangeForm(Vampire vampire)
            {
                Console.WriteLine($"{vampire.GetName()} is Nosferatu now. Run away!.\n");
            }
        }
    }

