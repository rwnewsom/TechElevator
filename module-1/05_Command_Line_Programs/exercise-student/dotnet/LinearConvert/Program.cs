using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDouble = false;
            double originalLength = 0;
            Console.WriteLine("*.* Linear Conversion Utility *.*");
            Console.WriteLine("Please enter the length:");
            string reply = Console.ReadLine();
            isDouble = double.TryParse(reply, out originalLength);
            while (isDouble == false)
            {
                Console.WriteLine("Please enter a valid response (decimal numbers only");
                string newReply = Console.ReadLine();
                isDouble = double.TryParse(newReply, out originalLength);
            }

            if (originalLength < 0)
            {
                Console.WriteLine("Negative numbers are acceptable.");
            }

            
            Console.WriteLine("Is the measurement in (m)eters or (f)eet?");

            string scale = "";
            bool validString = false;
            scale = Console.ReadLine().ToLower();
            while (validString == false)
            {                
                if (scale == "f")
                {
                    validString = true;
                    double meters = Math.Round((originalLength * 0.3048),2);
                    Console.WriteLine($"{originalLength}{scale} is {meters}m");
                }
                else if (scale == "m")
                {
                    validString = true;
                    double feet = Math.Round((originalLength * 3.2808399), 2);
                    Console.WriteLine($"{originalLength}{scale} is {feet}f");
                }
                else
                {
                    Console.WriteLine("Error - please (m)eters or (f)eet [only 'm' or 'f' are acceptable]:");
                    string newReply = Console.ReadLine();
                    validString = false;
                    scale = newReply;
                }

            }





            
        }
    }
}
