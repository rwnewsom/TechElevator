using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public class ExceptionExamples
    {
        public int PerformDivision(int numerator, int divisor)
        {
            int result = numerator / divisor;

            Console.WriteLine($"{numerator} / {divisor} = {result}");  // This line will not execute because an Exception will be thrown inside the for loop

            return result;
        }

        /// <summary>
        /// Calculates the total room charges for a stay
        /// </summary>
        /// <param name="nights">The number of nights. Must be > 0.</param>
        /// <param name="numberOfGuests">The number of guests. Must be > 0.</param>
        /// <returns>The total charges</returns>
        public double CalculateHotelRoomCharges(int nights, int numberOfGuests)
        {
            const double ExtraGuestCharge = 20;
            const double RoomRate = 85;

            // Throw exceptions if the nights or number of guests doesn't make sense
            if (nights <= 0)
            {
                throw new ArgumentOutOfRangeException("nights", nights, "You must stay for at least one night");
            }
            if (numberOfGuests <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfGuests", numberOfGuests, "What are you even doing?");
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
                // DON'T do this: throw new Exception("Cannot withdraw....");
                // throw new InvalidOperationException("Cannot withdraw a negative amount");

                // throw new NegativeWithdrawalException("You can't withdraw negative amounts");
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
