using Facts_Server.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Facts_Server.DAOs
{
    public class FactsSqlDao : IFactsDao
    {
        private string connectionString;

        public FactsSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public ChuckNorrisFact AddFact(ChuckNorrisFact fact)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFact(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFact()
        {
            return false;
        }


        public List<ChuckNorrisFact> GetAllFacts()
        {
            List<ChuckNorrisFact> facts = new List<ChuckNorrisFact>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT id, quote FROM facts ORDER BY quote", conn);
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ChuckNorrisFact fact = new ChuckNorrisFact();

                    fact.Id = Convert.ToInt32(reader["id"]);
                    fact.Text = Convert.ToString(reader["quote"]);

                    facts.Add(fact);
                }
            }

            return facts;
        }

        public ChuckNorrisFact GetFactById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFact(ChuckNorrisFact fact)
        {
            throw new NotImplementedException();


            /*
            // Arrange
            IFactsDao dao = new FactsListDao();
            FactsController controller = new FactsController(dao);

            // Act
            List<ChuckNorrisFact> facts = controller.GetFactsList();

            // Assert
            facts.Count 
            */

        }
    }
}
