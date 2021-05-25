using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; } = "Tractor";
        public string Sound { get; } = "*rumble / vroooom*";

        public void PlowField()
        {
            Console.WriteLine("Farming away!");
        }

        public void BeginVerse()
        {
            Console.WriteLine("Behold the tale of the tractor!");
        }
    }
}
