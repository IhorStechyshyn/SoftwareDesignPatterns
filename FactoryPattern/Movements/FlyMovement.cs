using System;

namespace FactoryPattern.Movements
{
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}
