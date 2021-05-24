using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
    {
        public int ReserveAmount { get; private set; }

        public ReserveAuction(int reserveAmount, string itemName) : base(itemName)
        {
            this.ReserveAmount = reserveAmount;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            Console.WriteLine("Customized placebid called");

            if (offeredBid.BidAmount >= this.ReserveAmount)
            {
                // Returning whether or not we're the high bid
                return base.PlaceBid(offeredBid);
            } 
            else
            {
                Console.WriteLine("Bid below the reserve amount");
                offeredBid.DisplayDetails();

                // Bids below reserve amount will never be high bid
                return false;
            }
        }
    }
}
