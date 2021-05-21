using EncapsulationLecture.CarExamples;
using EncapsulationLecture.GameExamples;
using System;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Car -------------------------
            Car myCar = new Car();
            myCar.Model = "Civic";
            myCar.Honk();

            double miles = myCar.Drive(22);
            miles = myCar.Drive(80);
            Console.WriteLine("The car has driven: " +myCar.Odometer+ " miles.");


            double amount = myCar.Crash(17000);
            Console.WriteLine("The insurance will pay you: $" + amount);

            Car farrisCar = new Car();
            farrisCar.Model = "Mustang";
            farrisCar.Drive(100);
            farrisCar.Drive(350);
            farrisCar.Drive(500);
            //farrisCar.Drive(-950);
            //farrisCar.Odometer = 0;
            Console.WriteLine("Farris Beuler's Odometer is: " + farrisCar.Odometer);

            // Classes
            // Methods - Drive, FillGas
            // Properties - IsEngineOn, MilesDriven
            // Public / Private
            // Properties with Private Sets

            // Player in a Game -------------
            Player myPlayer = new Player("Handsome Jack");
            Console.WriteLine($"Welcome, {myPlayer.Name}\nYour health is {myPlayer.Health}");
            myPlayer.TakeDamage(10);
            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);
            myPlayer.TakeDamage(25);
            myPlayer.Heal(50);
            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);
            myPlayer.TakeDamage(200);
            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);


            //myPlayer.Name = "Adventure Girl"; -no set for this property

            // Class Documentation
            // Methods / Properties - Health, Damage, Heal
            // Constructors
            // This
            // Get-Only Properties
            // Void Methods
        }
    }
}
