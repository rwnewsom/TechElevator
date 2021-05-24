using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; private set; } = new Bid("Nobody", 0);

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; private set; }

        public Auction(string productName)
        {
            Console.WriteLine("Starting auction for " + productName);
        }

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        /// <summary>
        /// Ends the current auction
        /// </summary>
        public void EndAuction()
        {
            Console.WriteLine("The auction is over, the winner is " + this.CurrentHighBid.Bidder);
            this.HasEnded = true;
        }

        protected void StartAuction() // Protected can ONLY be called by this class or things that inherit from it
        {
            Console.WriteLine("The auction is now starting");
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            // Make sure we don't allow bids after auctions are over
            if (this.HasEnded)
            {
                Console.WriteLine("Cannot accept the bid. The auction has already ended");
                return false;
            }

            // Show the bid details to the user.
            offeredBid.DisplayDetails();

            // Record it as a bid by adding it to allBids
            this.allBids.Add(offeredBid);

            // Check to see IF the offered bid is higher than the current bid amount
            // -- if yes, set offered bid as the current high bid
            if (offeredBid.BidAmount > this.CurrentHighBid.BidAmount)
            {
                this.CurrentHighBid = offeredBid;
            }

            // Output the current high bid
            Console.WriteLine("The current high bid is: ");
            this.CurrentHighBid.DisplayDetails();

            // Return if this is the new highest bid
            return this.CurrentHighBid == offeredBid;
        }
    }
}
