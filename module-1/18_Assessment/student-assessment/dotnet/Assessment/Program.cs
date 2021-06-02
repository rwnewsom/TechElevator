using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.

            HotelReservation RobsRes = new HotelReservation("Rob", 4);
            //Console.WriteLine(RobsRes.EstimatedTotal);
            //Console.WriteLine(RobsRes.CalculateActualTotal(true,true));

            Console.WriteLine(RobsRes.ToString()); 

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();  
        }

        
    }
}
