using System;

namespace FactoryPattern.Movements
{
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }
}
