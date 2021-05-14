using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("*.* Decimal to Binary Conversion Tool *.*");
            Console.WriteLine("Enter a series of decimal values seperated by spaces:");
            string userInput = Console.ReadLine();
            string[] userArr = userInput.Split(' ');

            for (int i = 0; i < userArr.Length; i++)
            {
                int entry = int.Parse(userArr[i]);
                string binary = Convert.ToString(entry, 2);
                Console.WriteLine($"{entry} in binary is {binary}");
               
            }
            


        }
    }
}
