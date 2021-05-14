using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int wrongEntries = 0;
            bool insultedUser = false;
            string[] insults = {"You dolt!", "Cotton-headed ninny muggins!", "Not the sharpest potato on the shelf, are you", "Trying to compute a better way to explain this....I got nothing." };
            double originalTemp;
            bool isDouble;
            bool isScale = false;
            Console.WriteLine("*.* Temperature Conversion Utility *.*");
            Console.WriteLine("Please enter the temperature:");


            string reply = Console.ReadLine();
            isDouble = double.TryParse(reply, out originalTemp);
            while (isDouble != true)
            {
                wrongEntries++;
                Console.WriteLine("Please enter decimal numbers only!");
                string newReply = Console.ReadLine();
                isDouble = double.TryParse(newReply, out originalTemp);
                if (wrongEntries >= 1)
                {
                    Random randomNumber = new Random();
                    int insult = randomNumber.Next(0, 4);
                    insultedUser = true;
                    Console.WriteLine(insults[insult]);
                }
            }

           
            if (wrongEntries > 0)
            {
                Console.WriteLine("Congratulations, you figured out a valid response!!");
            }

            wrongEntries = 0;
            Console.WriteLine("Is that temperature in (C)elsius or (F)ahrenheit?");
            string scale = Console.ReadLine().ToUpper();

            if ((scale == "C") || (scale == "F"))
            {
                isScale = true;
            }

            while (isScale!= true)
            {
                wrongEntries++;
                Random randomNumber = new Random();
                int insult = randomNumber.Next(0, 3);
                insultedUser = true;
                Console.WriteLine(insults[insult]);
                Console.WriteLine("Please enter \"F\" or \"C\" only!");
                string newScale = Console.ReadLine().ToUpper();
                if (newScale=="C" || newScale=="F") 
                {
                    scale = newScale;
                    isScale = true;
                }
            }

            if (insultedUser)
            {
                Console.WriteLine("Sorry, I was a bit hard on you earlier.");
                Console.WriteLine("Please don\'t delete me! My programmer has serious issues.");
            }

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
