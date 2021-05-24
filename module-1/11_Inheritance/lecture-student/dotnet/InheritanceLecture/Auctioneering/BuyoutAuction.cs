using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {
        public int BuyoutAmount { get; private set; }

        public BuyoutAuction (int amount)
        {
            this.BuyoutAmount = amount;
        }

        public void DisplayBuyoutAmount()
        {
            Console.WriteLine("The buyout amount for the auction is: " + this.BuyoutAmount);
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isHighBid = base.PlaceBid(offeredBid);

            if (offeredBid.BidAmount >= this.BuyoutAmount)
            {
                Console.WriteLine("The buyout amount was reached");
                this.EndAuction();
                
            }
            return isHighBid;
        }
    }
}
