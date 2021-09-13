using System;

namespace SOLID
{
    public interface IThrowable
    {
        void Throw();
    }

    public class HandAxe : IThrowable
    {
        public void Throw()
        {
            Console.WriteLine("Handaxe makes your live shorty!\n");
        }
    }

    public class Shuriken : IThrowable
    {
        public void Throw()
        {
            Console.WriteLine("Ninja warrior knows your weak point! Pshuuuuh. Phuuush.\n");
        }
    }

//========================================================================================
    public class Warrior : IHuman
    {

        private IThrowable _throwableWeapon;
        public Warrior()
        {
            _throwableWeapon = new HandAxe();
        }

        public void DoAttack()
        {
            _throwableWeapon.Throw();          
        }
    }
//=========================================================================================

    public class EliteWarrior : IHuman
    {
        private IThrowable _throwableWeapon;
        public EliteWarrior(IThrowable throwableWeapon)
        {
            _throwableWeapon = throwableWeapon;
        }
        public void DoAttack()
        {
            _throwableWeapon.Throw();
        }
    }

//======================================================================================

    public class ShogunWarrior : IHuman
    {
        private IThrowable _throwableWeapon;

        public IThrowable Throwable {
            set {
                _throwableWeapon = value;
            }
        }
        public void DoAttack()
        {
            if (_throwableWeapon == null)
            {
                Console.WriteLine("Need a wepaon!");
            }
            else 
            { 
            _throwableWeapon.Throw();            
            }
        }
    }
    //=====================================================================================
    public class LazyWarrior : IHuman
    {
        public void AttackLazy(IThrowable throwableWeapon) 
        { 
            throwableWeapon.Throw();
        }  

        public void DoAttack()
        {
            Console.WriteLine("Too Lazy");
        }
    }
}
