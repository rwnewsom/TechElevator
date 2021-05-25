using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FarmAnimal animal = new Chicken(); // This is polymorphism

            //animal.LayEgg();
            Chicken chicken = (Chicken)animal; // Still the same Chicken in memory (heap)
            chicken.LayEgg();

            SingAbout(animal);

            // Goat time!

            FarmAnimal goat = new Goat();
            goat.Pet();
            // Can't do this since we're treating it as a FarmAnimal: goat.StandOnRoof();
            SingAbout(goat);

            // Sheep Time!

            Sheep sheep = new Sheep();
            sheep.Pet();
            sheep.Sheer();
            SingAbout(sheep);

            // Add a Tractor

            Tractor tractor = new Tractor();
            tractor.PlowField();
            SingAbout(tractor);


            // VERSION 2: With lists!

            List<ISingable> animals = new List<ISingable>();
            animals.Add(new Chicken());
            animals.Add(new Goat());
            animals.Add(new Sheep());
            animals.Add(new Tractor());

            foreach (ISingable critter in animals)
            {
                SingAbout(critter);
            }
        }

        private static void SingAbout(ISingable animal)
        {
            animal.BeginVerse();

            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine("And on his farm he had a " + animal.Name + ", ee ay ee ay oh!");
            Console.WriteLine("With a " + animal.Sound + " " + animal.Sound + " here");
            Console.WriteLine("And a " + animal.Sound + " " + animal.Sound + " there");
            Console.WriteLine("Here a " + animal.Sound + " there a " + animal.Sound + " everywhere a " + animal.Sound + " " + animal.Sound);
            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine();
        }
    }
}