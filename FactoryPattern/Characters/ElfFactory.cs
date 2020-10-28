using FactoryPattern.Movements;
using FactoryPattern.Weapons;

namespace FactoryPattern.Characters
{
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
