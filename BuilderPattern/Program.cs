using System;

namespace SoftwareDesignPatterns
{ 
    class Program
    {
        //Base, Life and Zen versions are real car's version in Renault company
        //In terms of my program Base version has only air condition option,
        //Life version has air condition and automatic transmission options,
        //Zen version has air condition, automatic transmission and all wheel drive options
        //If you want to buy new car and you like France companies please visit their web page: https://www.renault.ua/
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard BASE version of car:");
            director.BuildBaseVersion();
            Console.WriteLine(builder.GetCar().ListOptions());

            Console.WriteLine("Standard LIFE version of car:");
            director.BuildLifeVersion();
            Console.WriteLine(builder.GetCar().ListOptions());

            Console.WriteLine("Standard ZEN version of car:");
            director.BuildZenVersion();
            Console.WriteLine(builder.GetCar().ListOptions());

            Console.Read();
        }
    }
}
