using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pterodactyl : FlyingFarmAnimal
    {
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
