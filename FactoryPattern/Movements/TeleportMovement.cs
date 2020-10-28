using System;

namespace FactoryPattern.Movements
{
    class TeleportMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Teleporting");
        }
    }
}
