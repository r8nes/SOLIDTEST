using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //================== Single Responsibility Principle ============================


            Vampire edwardCullen = new Vampire("Edward", 112);
            Vampire bellaCullen = new Vampire("Bella", 18);

            VampireInfo.Check(edwardCullen);
            VampireInfo.Check(bellaCullen);

        
            //====================================================

            List<Vampire> cullenClan = new List<Vampire>();

            cullenClan.Add(edwardCullen);
            cullenClan.Add(bellaCullen);

            VampireInfo.Check(cullenClan);

            Console.WriteLine(new string('_', 60));
            //===================== Open - Closed Principle =============================

            BatForm batForm = new BatForm();
            batForm.ChangeForm(edwardCullen);

            NosferatuForm nosferatuForm = new NosferatuForm();
            nosferatuForm.ChangeForm(bellaCullen);

            //======================================================


            BatForm2 batForm2 = new BatForm2();
            batForm2.ChangeForm(edwardCullen);

            NosferatuForm2 nosferatuForm2 = new NosferatuForm2();
            nosferatuForm2.ChangeForm(bellaCullen);

            Console.WriteLine(new string('_', 60));
            //======================== Liskov Substitution Principle ==========================

            List<IMonster> monsters = new List<IMonster>();

            monsters.Add(new Werewolf());
            monsters.Add(new Wolf());

            foreach (var monster in monsters)
            {
                monster.Bite();
            }
            Console.WriteLine(new string('_', 60));
            //========================= Dependency Inversion Principle ==================================
            Shuriken shuriken = new Shuriken();

            Warrior warrior = new Warrior();
            warrior.DoAttack();

            //================================================================================

            EliteWarrior eliteWarrior = new EliteWarrior(shuriken);
            eliteWarrior.DoAttack();

            //================================================================================


            ShogunWarrior shogunWarrior = new ShogunWarrior();
            shogunWarrior.DoAttack();

            shogunWarrior.Throwable = shuriken;
            shogunWarrior.DoAttack();

            //================================================================================

            LazyWarrior lazyWarrior = new LazyWarrior();
            lazyWarrior.DoAttack();
            lazyWarrior.AttackLazy(shuriken);

            Console.WriteLine(new string('_', 60));
            //========================= Interface Segregation Principle ================================

            edwardCullen.DrinkBlood(warrior);
            edwardCullen.Infect(warrior);
        }
    }
}
