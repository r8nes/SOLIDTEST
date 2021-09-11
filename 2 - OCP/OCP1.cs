using System;
using SOLID.SRP;

namespace SOLID.OCP1
{ 
        public class Form
        {
            public virtual void ChangeForm(Vampire vampire)
            {
                Console.WriteLine($"{vampire.GetName()} is trying change form.\n");
            }
        }

        public class BatForm : Form
        {
            public override void ChangeForm(Vampire vampire)
            {
                Console.WriteLine($"{vampire.GetName()} is trying change form. Batmanpire appeared.\n");
            }
        }

        public class NosferatuForm : Form
        {
            public override void ChangeForm(Vampire vampire)
            {
                Console.WriteLine($"{vampire.GetName()} is Nosferatu now. Run away!.\n");
            }
        }
    }

