using System;
using System.Collections.Generic;
using SOLID.SRP;

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
        }
    }
}
