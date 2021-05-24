using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction //always put public 
    {
       
        //PROPERTIES
        public int ReserveAmount { get; private set; }


        //CONSTRUCTORS
        public ReserveAuction(int reserveAmount)
        {
            this.ReserveAmount = reserveAmount;
        }

        //OVERRIDE METHOD - C# Specific
        //main method must have 'virtual'

        public override bool PlaceBid(Bid offeredBid)
        {
            Console.WriteLine("Customized placebid called");

            if(offeredBid.BidAmount > this.ReserveAmount)
            {
                
                //use base to refer to default method if you used override
                return base.PlaceBid(offeredBid);
            }
            else
            {
                Console.WriteLine("Bid below the reserve amount");
                offeredBid.DisplayDetails();
                //bids below reserve amount will never be high bid
                return false;
            }
            
        }
    }
}
