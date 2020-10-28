using FactoryPattern.Movements;
using FactoryPattern.Weapons;

namespace FactoryPattern.Characters
{
    class SuperHeroFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new TeleportMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Gun();
        }
    }
}
