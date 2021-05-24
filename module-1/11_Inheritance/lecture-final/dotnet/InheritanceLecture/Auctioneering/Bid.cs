using System;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a specific bid on an item by a particular bidder.
    /// </summary>
    public class Bid : System.Object // You don't need to explicitly say that you inherit from Object
    {
        /// <summary>
        /// Get the bidder name.
        /// </summary>
        public string Bidder { get; } // Can only be set by a constructor

        /// <summary>
        /// Get the bid amount.
        /// </summary>
        public int BidAmount { get; } // Can only be set by the constructor

        public string DisplayText // We can call this using: Console.WriteLine(myBid.DisplayText);
        {
            get
            {
                return this.Bidder + " bid " + this.BidAmount;
            }
        }

        /* Don't do this. You'll get an infinite loop:
        public string DisplayText2
        {
            get 
            {
                return this.DisplayText2;
            }
        }
        */

        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount) // Bid myBid = new Bid("Matt", 5);
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }

        /// <summary>
        /// Displays information on the bidder and the bid amount to the user.
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine(this.Bidder + " with " + this.BidAmount.ToString("C")); // ToString("C") formats as a currency. E.G. $24
        }

        public void DisplayDetails(string someMessage)
        {
            Console.WriteLine(someMessage);
        }

        public override string ToString()
        {
            return this.Bidder + ": " + this.BidAmount.ToString("C");
        }
    }
}
