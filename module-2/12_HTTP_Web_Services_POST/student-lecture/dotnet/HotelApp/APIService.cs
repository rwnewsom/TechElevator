using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    class APIService
    {
        private readonly string API_URL = "https://te-mockauction-server.azurewebsites.net/students/01872/";
        private readonly RestClient client = new RestClient();

        public APIService(string api_url)
        {
            API_URL = api_url;
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest(API_URL + "Reservations/" + reservationId);
            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            return response.Data;
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(API_URL + "Hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            // check that we are able to connect to the server
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("could not communicate with the server");
                return null;
            }

            //check that the server responded with the expected status code
            if(response.StatusCode != System.Net.HttpStatusCode.OK) //note we could also check response.IsSuccessful
            {
                Console.WriteLine("Could not get");
                return null;
            }

            return response.Data;
            
        }

        public List<Reservation> GetReservations()
        {
            RestRequest request = new RestRequest(API_URL + "reservations");
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);
            return response.Data;

        }

        public List<Reservation> GetReservations(int hotelId)
        {
            // /students/{studentId}/hotels/{hotelId}/reservations
            RestRequest request = new RestRequest(API_URL + "hotels/" + hotelId + "/reservations");
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);
            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            // POST /students/{studentId}/reservations
            RestRequest request = new RestRequest(API_URL + "reservations");
            request.AddJsonBody(newReservation); //auto converts newReservation to JSON
            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            //Note should have error handling
            if(response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not create reservation: " + response.StatusDescription);
                return null;
            }
            return response.Data;
            

        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            // PUT /students/{studentId}/reservations/{id}
            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationToUpdate.Id);
            //add body to request
            request.AddJsonBody(reservationToUpdate); //if POST or PUT should be ussing .ADDJsonBody!!
            
            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            if(response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server");
                return null; //makes it clear something went wrong
            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not update reservation: " + response.StatusDescription);
                return null;
            }
            return response.Data;
        }


        public void DeleteReservation(int reservationId)
        {
            //DELETE /students/{studentId}/reservations/{id}
            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationId);

            IRestResponse response = client.Delete(request);

            if(response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("could not communicate with server");
                return;
            }

            if (!response.IsSuccessful) //if not sure what status code, also easier to copy & paste
            //if(response.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                Console.WriteLine("Could not delete reservation " + response.StatusDescription);
                return;
            }
        }
    }
}
