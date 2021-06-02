using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class HotelReservation
    {
        //PROPERTIES
        public string Name { get; private set; }

        public int NumberOfNights { get; private set; }

        public double EstimatedTotal
        {
            get
            {
                return NumberOfNights * 59.99;
            }
        }

        //CONSTRUCTORS

        public HotelReservation(string name, int numberOfNights)
        {
            this.Name = name;
            this.NumberOfNights = numberOfNights;
        }

        

        //METHODS
        /// <summary>
        /// Calculate actual hotel bill.
        /// </summary>
        /// <param name="requiresCleaning">True if guest trashed the room.</param>
        /// <param name="usedMinibar">True if guest touched the minibar, even if no PBR was removed.</param>
        /// <returns>An exhorbinant bill.</returns>
        public double CalculateActualTotal(bool requiresCleaning, bool usedMinibar)
        {
            double minibarFee = 12.99;
            double cleaningFee = 34.99;
            if (usedMinibar && requiresCleaning)
            {
                return this.EstimatedTotal + minibarFee + 2 * cleaningFee;
            }

            else if (usedMinibar)
            {
                return this.EstimatedTotal + minibarFee;
            }

            else if (requiresCleaning)
            {
                return this.EstimatedTotal + cleaningFee;
            }
            return EstimatedTotal;
        }

        public override string ToString()
        {
            return $"RESERVATION - {this.Name} - {this.EstimatedTotal}";
        }

        //public override string ToString()

        //return;

    }
}
