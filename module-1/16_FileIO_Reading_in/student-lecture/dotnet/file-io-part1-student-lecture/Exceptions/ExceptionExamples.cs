using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public class ExceptionExamples
    {
        public void DoSomethingDangerous()
        {
            int x = 42;
            int y = 0;

            int result = x / y; // Will cause a divide by zero exception

            Console.WriteLine($"{x} / {y} = {result}");  // This line will not execute because an Exception will be thrown inside the for loop
        }

        public double CalculateHotelRoomCharges(int nights, int numberOfGuests)
        {
            const double ExtraGuestCharge = 20;
            const double RoomRate = 85;

            /* The throw statements below demonstrate how to throw a new Exception. */
            if (nights < 1)
            {
                throw new ArgumentOutOfRangeException("nights", nights, "Minimum number of nights is 1");
            }
            if (numberOfGuests < 1)
            {
                throw new ArgumentOutOfRangeException("numberOfGuests", numberOfGuests, "Minimum number of guests is 1");
            }

            int numberOfExtraGuests = 0;
            if (numberOfGuests > 4)
            {
                numberOfExtraGuests = numberOfGuests - 4;
            }

            double dailyRate = RoomRate + (ExtraGuestCharge * numberOfExtraGuests);
            return dailyRate * nights;
        }

        public double Withdraw(double amount)
        {
            const double StartingBalance = 5000.00;

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, "Amount to withdraw must be above zero");
            }

            double finalBalance = StartingBalance - amount;

            if (finalBalance < 0)
            {
                throw new OverdraftException("You cannot overdraft this account", finalBalance);
            }

            return finalBalance;
        }

    }
}
