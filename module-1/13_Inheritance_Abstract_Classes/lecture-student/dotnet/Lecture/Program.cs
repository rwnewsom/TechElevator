using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ISingable> animals = new List<ISingable>();
            animals.Add(new Chicken());
            animals.Add(new Goat());
            animals.Add(new Sheep());
            animals.Add(new Tractor());
            animals.Add(new Pterodactyl());

            // TODO: Old Macdonald needs a Cat

            foreach (ISingable critter in animals)
            {
                SingAbout(critter);
            }
        }

        private static void SingAbout(ISingable animal)
        {
            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine("And on his farm he had a " + animal.Name + ", ee ay ee ay oh!");
            Console.WriteLine("With a " + animal.MakeSound() + " " + animal.MakeSound() + " here");
            Console.WriteLine("And a " + animal.MakeSound() + " " + animal.MakeSound() + " there");
            Console.WriteLine("Here a " + animal.MakeSound() + " there a " + animal.MakeSound() + " everywhere a " + animal.MakeSound() + " " + animal.MakeSound());
            Console.WriteLine("Old MacDonald had a farm, ee ay ee ay oh!");
            Console.WriteLine();
        }
    }
}