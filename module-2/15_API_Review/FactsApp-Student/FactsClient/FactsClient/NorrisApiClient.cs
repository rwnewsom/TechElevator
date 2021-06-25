using System.Collections.Generic;
using RestSharp;

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

        public IEnumerable<NorrisApiFact> GetAllFacts()
        {
            // TODO: Get a list from the server instead of returning this list

            return new List<NorrisApiFact>();
        }

        public NorrisApiFact GetFact(int id)
        {
            // TODO: Get the fact from the API

            return null;
        }

        public void EditFact(int id, NorrisApiFact fact)
        {
            // TODO: Update the fact on the API
        }

        public bool DeleteFact(int id)
        {
            // TODO: Delete the fact on the API and return true if the fact was deleted and false if it wasn't

            return false;
        }

        public int AddFact(NorrisApiFact newFact)
        {
            // TODO: Create the fact on the server via the API and return its new ID or -1 if no fact was created

            return -1;
        }
    }
}