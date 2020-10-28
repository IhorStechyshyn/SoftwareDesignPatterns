using System;

namespace FactoryPattern.Weapons
{
    class Gun : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shooting from gun");
        }
    }
}
