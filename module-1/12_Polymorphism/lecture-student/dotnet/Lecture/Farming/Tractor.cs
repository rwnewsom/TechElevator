using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; } = "Tractor";
        public string Sound { get; } = "*rumble / vrooom*";

        public void PlowField()
        {
            Console.WriteLine("Farming Away!");
        }

        public void BeginVerse()
        {
            Console.WriteLine("Behold the tale of the tractor");
        }
    }
}
