using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; } = "Tractor";

        public string MakeSound()
        {
            return "VROOOOOOOOOOOOOOOOOOOM!!!";
        }

        public void PlowField()
        {
            Console.WriteLine("Plowing away!");
        }
    }
}
