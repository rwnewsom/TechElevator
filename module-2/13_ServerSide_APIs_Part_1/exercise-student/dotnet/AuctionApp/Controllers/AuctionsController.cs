using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        /// <summary>
        /// Generates a list of auctions (search optional)
        /// </summary>
        /// <param name="title_like">optional title to search for</param>
        /// <param name="currentBid_lte">optional value bid should not exceed</param>
        /// <returns>A list of Auction objects</returns>
        [HttpGet("/auctions")]
        public List<Auction> GetAllAuctions(string title_like = "", double currentBid_lte = 0)
        {
            if (string.IsNullOrEmpty(title_like))
            {
                if (currentBid_lte == 0)
                {
                    return dao.List();
                }
                return dao.SearchByPrice(currentBid_lte);
                
            }
            else
            {
                if(currentBid_lte == 0)
                {
                    return dao.SearchByTitle(title_like);
                }
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }


        }

        /// <summary>
        /// searches for a single auction by id
        /// </summary>
        /// <param name="id">the id to search for</param>
        /// <returns>An Auction object</returns>
        [HttpGet("/auctions/{id}")]
        public Auction GetAuctionById(int id)
        {
            return dao.Get(id);
        }

        /// <summary>
        /// Creates a new auction
        /// </summary>
        /// <param name="auction">An auction object</param>
        /// <returns>An auction object</returns>
        [HttpPost("/auctions")]
        public Auction CreateAuction(Auction auction)
        {
            return dao.Create(auction);
        }
    }
}
