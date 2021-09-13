using System;

namespace SOLID
{
    public interface IMonster
    {
        void Bite();
    }

    public interface IHuman
    {
        void DoAttack();
    }

    public class Werewolf : IHuman, IMonster
    {
        public void Bite()
        {
            Console.WriteLine("Bite!");
        }

        public void DoAttack()
        {
            Console.WriteLine("Punch");
        }
    }

    public class Wolf : IMonster
    {
        public void Bite()
        {
            Console.WriteLine("Bite!");
        }
    }
}
