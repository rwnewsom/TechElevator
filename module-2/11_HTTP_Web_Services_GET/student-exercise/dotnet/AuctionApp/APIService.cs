using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API documentation and notes in the readme on relevant methods and working with studentId / id
        // Your requests should go to something like https://te-mockauction-server.azurewebsites.net/students/{YOUR_LAPTOP_ID_HERE}/...

        private readonly RestClient client;
        private readonly string BASE_URL;

        public APIService(string laptopNumber)
        {
            this.client = new RestClient();

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
            
        }


        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(BASE_URL + "auctions/");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(BASE_URL + "auctions/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            
            RestRequest request = new RestRequest(BASE_URL + "auctions?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(BASE_URL + "auctions?currentbid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);

            return response.Data;
        }
    }
}
