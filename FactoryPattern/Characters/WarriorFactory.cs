using FactoryPattern.Movements;
using FactoryPattern.Weapons;

namespace FactoryPattern.Characters
{
    class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
