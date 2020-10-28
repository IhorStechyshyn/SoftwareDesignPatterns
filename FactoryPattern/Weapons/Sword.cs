using System;

namespace FactoryPattern.Weapons
{
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Hitting by sword");
        }
    }
}
