using FactoryPattern.Characters;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elf character: ");
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Console.WriteLine("\nWarrior character: ");
            Hero warrior = new Hero(new WarriorFactory());
            warrior.Hit();
            warrior.Run();

            Console.WriteLine("\nSuperhero character: ");
            Hero deadpool = new Hero(new SuperHeroFactory());
            deadpool.Hit();
            deadpool.Run();

            Console.Read();
        }
    }
}
