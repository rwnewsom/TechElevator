using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FarmAnimal animal = new Chicken();

            SingAbout(animal);
        }

        private static void SingAbout(FarmAnimal animal)
        {
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