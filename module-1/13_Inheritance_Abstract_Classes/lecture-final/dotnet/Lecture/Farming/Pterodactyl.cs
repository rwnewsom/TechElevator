using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pterodactyl : FlyingFarmAnimal
    {

        public override double WeightInPounds { get; } = 90.0;

        public Pterodactyl() : base("Pterodactyl")
        {
        }

        public override string MakeSound()
        {
            return "Ca-caw!";
        }

        public void EatTourist()
        {
            Console.WriteLine("Tourist is back on the menu!");
        }
    }
}
