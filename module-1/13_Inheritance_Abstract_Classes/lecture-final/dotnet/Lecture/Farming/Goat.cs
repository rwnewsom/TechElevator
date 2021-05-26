using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Goat : FarmAnimal
    {

        private bool isOnARoof;

        public int GallonsOfMilk { get; set; }
        public int NumberOfHorns { get; set; } = 2;

        public override double WeightInPounds { get; } = 16.0;

        public Goat() : base("Goat")
        {

        }

        public override string MakeSound()
        {
            return "Behhhh";
        }

        public void StandOnRoof()
        {
            Console.WriteLine("I'm on a roof!");
        }
    }
}
