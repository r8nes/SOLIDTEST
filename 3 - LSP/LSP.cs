using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP
{
    public interface IMonster
    {
        void Bite();
    }

    public interface IHuman
    {
        void Punch();
    }

    public class Werewolf : IHuman, IMonster
    {
        public void Bite()
        {
            Console.WriteLine("Bite!");

        }

        public void Punch()
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
