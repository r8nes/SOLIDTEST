using System;
using System.Collections.Generic;
using SOLID.SRP;
using SOLID.OCP1;
using SOLID.OCP2;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Single Responsibility Principle


            Vampire edwardCullen = new Vampire("Edward", 112);
            Vampire bellaCullen = new Vampire("Bella", 18);

            VampireInfo.Check(edwardCullen);
            VampireInfo.Check(bellaCullen);

//=============================================================
            
            List<Vampire> cullenClan = new List<Vampire>();
            
            cullenClan.Add(edwardCullen);
            cullenClan.Add(bellaCullen);

            VampireInfo.Check(cullenClan);


            // Open - Closed Principle

            BatForm batForm = new BatForm();
            batForm.ChangeForm(edwardCullen);

            NosferatuForm nosferatuForm = new NosferatuForm();
            nosferatuForm.ChangeForm(bellaCullen);

            //==============================================================

            
            BatForm2 batForm2 = new BatForm2();
            batForm2.ChangeForm(edwardCullen);

            NosferatuForm2 nosferatuForm2 = new NosferatuForm2();
            nosferatuForm2.ChangeForm(bellaCullen);

        }
    }
}
