using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        
        //STATIC means it is associated with the CLASS as opposed to an instance of a class
        //Avoid it because they can only work with other STATIC methods
        
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction();

            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("John", 13));
            generalAuction.PlaceBid(new Bid("Rick Astley", 23));

            generalAuction.EndAuction();
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            // Create a new Reserve auction (buyer can reject small bids)

            ReserveAuction reserveAuction = new ReserveAuction(20000);

            reserveAuction.PlaceBid(new Bid("Matt", 1));
            reserveAuction.PlaceBid(new Bid("Rachelle", 24000));

            reserveAuction.EndAuction();

            // Create a new Buyout auction (big bids can end the auction)

            BuyoutAuction buyoutAuction = new BuyoutAuction(250);

            buyoutAuction.DisplayBuyoutAmount();

            buyoutAuction.PlaceBid(new Bid("Austin", 2));
            buyoutAuction.PlaceBid(new Bid("Ben", 300));

            
            Console.ReadLine();
        }
    }
}
