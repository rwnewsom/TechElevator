using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class HotelsApi
    {
        private readonly RestClient client;
        private readonly string BASE_URL;

        public HotelsApi(string laptopNumber)
        {
            this.client = new RestClient();

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
        }

        public List<Hotel> GetAllHotels()
        {
            RestRequest request = new RestRequest(BASE_URL + "hotels");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

        public List<Reservation> GetAllReservations()
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations");
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public Hotel GetHotel(int hotelId)
        {
            RestRequest request = new RestRequest(BASE_URL +"hotels/" + hotelId); // 
            IRestResponse<Hotel> response = client.Get<Hotel>(request);

            return response.Data;
        }

        public List<Reservation> GetReservationsForHotel(int hotelId)
        {
            RestRequest request = new RestRequest($"{BASE_URL}hotels/{hotelId}/reservations");
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public List<Hotel> GetAllHotelsInState(string state)
        {
            // /hotels/filter?state=OH

            RestRequest request = new RestRequest($"{BASE_URL}hotels/filter?state={state}");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

    }
}
