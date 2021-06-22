using HTTP_Web_Services_GET_lecture.Data;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class TravelApi
    {
        public string GetRecommendedDestination()
        {
            // TODO: Call out to http://swapi.dev/api/planets/17/
            RestClient client = new RestClient();

            RestRequest request = new RestRequest("http://swapi.dev/api/planets/17/");
            IRestResponse<Planet> response = client.Get<Planet>(request);

            Planet destination = response.Data;

            return destination.Name + " has a climate of " + destination.Climate + 
                ", " + destination.Gravity + " and you can expect " + destination.Terrain;
        }
    }
}
