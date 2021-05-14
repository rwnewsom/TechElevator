using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*.* Temperature Conversion Utility *.*");
            Console.WriteLine("Please enter the temperature:");
            double originalTemp = Double.Parse(Console.ReadLine());
            Console.WriteLine("Is that temperature in (C)elsius or (F)ahrenheit?");
            string scale = Console.ReadLine().ToUpper();

            if (scale == "F")
            {
                double celsius = Math.Round((originalTemp - 32) / 1.8);
                Console.WriteLine($"{originalTemp}{scale} is {celsius}C");
            }
            else if (scale == "C")
            {
                double fahrenheit = Math.Round((originalTemp * 1.8) + 32);
                Console.WriteLine($"{originalTemp}{scale} is {fahrenheit}F");
            }
            else
            {
                Console.WriteLine("Error - please enter a valid response next time.");
            }
        }
    }
}
