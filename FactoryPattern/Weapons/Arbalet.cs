using System;

namespace FactoryPattern.Weapons
{
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shooting from arbalet");
        }
    }
}
