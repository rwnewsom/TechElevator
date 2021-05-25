using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Sheep : FarmAnimal
    {
        public int DaysSinceLastShorn { get; set; }

        public Sheep() : base("Sheep", "Baaaa")
        {

        }

        public void Sheer()
        {
            Console.WriteLine("You sheer the sheep");
            this.DaysSinceLastShorn = 0;
        }
    }
}
