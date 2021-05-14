using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*.* Temperature Conversion Utility *.*");
            Console.WriteLine("Please enter the length:");
            double originalLength = Double.Parse(Console.ReadLine());
            Console.WriteLine("Is the measurement in (m)eters or (f)eet?");
            string scale = Console.ReadLine().ToLower();

            if (scale == "f")
            {
                double meters = (originalLength * 0.3048);
                Console.WriteLine($"{originalLength}{scale} is {meters}m");
            }
            else if (scale == "m")
            {
                double feet = (originalLength * 3.2808399);
                Console.WriteLine($"{originalLength}{scale} is {feet}f");
            }
            else
            {
                Console.WriteLine("Error - please enter a valid response next time.");
            }
        }
    }
}
