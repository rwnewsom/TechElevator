﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Goat : FarmAnimal
    {
        public int GallonsOfMilk { get; set; }
        public int NumberOfHorns = 2;

        public Goat() : base("Goat", "Bahhh")
        {

        }

        public void StandOnRoof()
        {
            Console.WriteLine("I'm on a roof!");
        }
    }
}
