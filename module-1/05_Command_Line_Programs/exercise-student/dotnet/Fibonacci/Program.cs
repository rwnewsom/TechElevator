using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        
               
        {
            Console.WriteLine("*.* Fibonacci Sequence Generator *.*");
            Console.WriteLine("Please enter an integer:");
            string userinput = Console.ReadLine();
            int fibTarget = int.Parse(userinput);
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
