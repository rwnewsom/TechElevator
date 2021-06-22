using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    class APIService
    {
        private readonly string API_URL;
        private readonly RestClient client = new RestClient();

        public APIService(string api_url)
        {
            API_URL = api_url;
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest(API_URL + "Reservations/" + reservationId);

            IRestResponse<Reservation> response = client.Get<Reservation>(request); // Deserialization

            // NOTE: should have standard error handling

            return response.Data;
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(API_URL + "Hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            // Check that we were able to connect to the server
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with the server");
                return null;
            }

            // Check that the server responded with the expected status code
            if (response.StatusCode != System.Net.HttpStatusCode.OK) // NOTE: we could also just check response.IsSuccessful
            {
                Console.WriteLine("Could not get hotels: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public List<Reservation> GetReservations()
        {
            RestRequest request = new RestRequest(API_URL + "reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            // NOTE: should have standard error handling

            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId)
        {
            // /students/{studentId}/hotels/{hotelId}/reservations

            RestRequest request = new RestRequest(API_URL + "hotels/" + hotelId + "/reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            // NOTE: should have standard error handling

            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            // POST /students/{studentId}/reservations

            RestRequest request = new RestRequest(API_URL + "reservations");

            request.AddJsonBody(newReservation); // Automatically converts newReservation to JSON (Serialization)

            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
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

            request.AddJsonBody(reservationToUpdate);

            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server");
                return null;
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
            // DELETE /students/{studentId}/reservations/{id}

            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationId);

            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server");
                return;
            }

            //if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not delete reservation: " + response.StatusDescription);
                return;
            }


        }
    }
}
