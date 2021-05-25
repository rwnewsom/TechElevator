using System;

namespace Lecture.Farming
{
    public class Chicken : FlyingFarmAnimal
    {
        public Chicken() : base("Chicken")
        {

        }

        public override string MakeSound()
        {
            return "cluck";
        }

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
    }
}
