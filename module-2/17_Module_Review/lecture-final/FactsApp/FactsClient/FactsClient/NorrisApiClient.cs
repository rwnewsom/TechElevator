using System;
using System.Collections.Generic;
using RestSharp;
using RestSharp.Authenticators;

namespace FactsClient
{
    public class NorrisApiClient
    {
        private readonly string baseUrl;
        private readonly RestClient client;

        public NorrisApiClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
            this.client = new RestClient();
        }

        public bool LogIn(string username, string password)
        {
            // TODO: Create an object to represent the login attempt
            // var myObj = new { username = username, password = password };
            LoginData login = new LoginData();
            login.Username = username;
            login.Password = password;

            // TODO: Call to the server
            RestRequest request = new RestRequest(baseUrl + "login");
            request.AddJsonBody(login);

            IRestResponse<LoginResult> response = client.Post<LoginResult>(request);

            if (response.IsSuccessful && response.ResponseStatus == ResponseStatus.Completed)
            {
                LoginResult result = response.Data;

                client.Authenticator = new JwtAuthenticator(result.Token);
                // TODO: Store the token in a new field

                return true;
            }

            Console.WriteLine("Unable to log in: " + response.StatusDescription);

            return false;
        }

        public IEnumerable<NorrisApiFact> GetAllFacts()
        {
            RestRequest request = new RestRequest(baseUrl + "facts");

            IRestResponse<List<NorrisApiFact>> response = client.Get<List<NorrisApiFact>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public NorrisApiFact GetFact(int id)
        {
            RestRequest request = new RestRequest(baseUrl + "facts/" + id);

            IRestResponse<NorrisApiFact> response = client.Get<NorrisApiFact>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public void EditFact(int id, NorrisApiFact fact)
        {
            // Ensure the ID of the fact is set
            fact.Id = id;

            RestRequest request = new RestRequest(baseUrl + "facts");
            request.AddJsonBody(fact);

            IRestResponse response = client.Put(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return;
            }

            return;
        }

        public bool DeleteFact(int id)
        {
            RestRequest request = new RestRequest(baseUrl + "facts/" + id);

            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return false;
            }

            return true;
        }

        public int AddFact(NorrisApiFact newFact)
        {
            RestRequest request = new RestRequest(baseUrl + "facts");
            request.AddJsonBody(newFact);

            IRestResponse<NorrisApiFact> response = client.Post<NorrisApiFact>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server");
                return -1;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Oh noes! An error occurred: " + response.StatusDescription);
                return -1;
            }

            NorrisApiFact createdFact = response.Data;

            return createdFact.Id;
        }
    }
}