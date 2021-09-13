using System;

namespace SOLID
{

    //interface IMonstrosity
    //{
    //    public void Infect(IHuman human);
    //    public void DrinkBlood(IHuman human);
    //    public void EatPrey(IHuman human);
    //}

    interface IInfect
    {
        public void Infect(IHuman human);
    }

    interface IBloodDrinkable
    {
        public void DrinkBlood(IHuman human);
    }

    interface IMenEater 
    {
       public void EatPrey();
    }
    
    public partial class Vampire : IInfect, IBloodDrinkable
    {
        public void DrinkBlood(IHuman human)
        {
            Console.WriteLine("Nice blood\n");
        }

        public void Infect(IHuman human)
        {
        }
    }
}