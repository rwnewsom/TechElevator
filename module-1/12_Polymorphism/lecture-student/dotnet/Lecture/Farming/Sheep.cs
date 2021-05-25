using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Sheep : FarmAnimal
    {
        public int DaysSinceLastShorn { get; set; }

        public Sheep() : base("Sheep", "Baa")
        {

        }

        // sheer method
        //animal needs pet method
    }
}
