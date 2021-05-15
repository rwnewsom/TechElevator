using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        
               
        {
            Console.WriteLine("*.* Fibonacci Sequence Generator *.*");
            Console.WriteLine("Please enter a number:");
            bool isInt = false;
            int fibTarget = 0;
            string userinput = Console.ReadLine();
            isInt = int.TryParse(userinput, out fibTarget);
            while (isInt == false)
            {
                Console.WriteLine("Error, expected numerical entry.");
                Console.WriteLine("Please enter a number:");
                string newReply = Console.ReadLine();
                isInt = int.TryParse(newReply, out fibTarget);
            }
            
            if (fibTarget <= 0)
            {
                Console.Write("0, 1");
            }
            else
            {
                int current = 1;
                int previous = 1;
                Console.Write("0, 1, 1");
                while (current < fibTarget)
                {
                    int next = (current + previous);
                    if (next > fibTarget)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($", {next}");
                        previous = current;
                        current = next;
                    }
                    
                }

            }
        }
    }
}
