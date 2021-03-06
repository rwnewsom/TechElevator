using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Transactions;

namespace WorldGeography.Tests.DAL
{
    [TestClass]
    public abstract class WorldDAOTestsBase
    {
        protected string ConnectionString { get; } = "Server=.\\SQLEXPRESS;Database=World;Trusted_Connection=True;";

        /// <summary>
        /// Holds the newly generated city id.
        /// </summary>
        protected int NewCityId { get; private set; }

        /// <summary>
        /// The transaction for each test.
        /// </summary>
        private TransactionScope transaction;

        [TestInitialize]
        public void Setup()
        {
            // Begin the transaction
            transaction = new TransactionScope(); //equivalent to BEGIN Transaction

            // Get the SQL Script to run
            string sql = File.ReadAllText("test-script.sql"); //short files only!! //use stream reader fo longer files

            // Execute the script
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // If there is a row to read
                if (reader.Read())
                {
                    this.NewCityId = Convert.ToInt32(reader["newCityId"]);
                }
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Roll back the transaction
<<<<<<< HEAD
            transaction.Dispose(); //equivalent to rollback
=======
            if (transaction != null)
            {
                transaction.Dispose();
            }
>>>>>>> 305ad0e3cb8824065a717fa0d9870fad57d53f2c
        }

        /// <summary>
        /// Gets the row count for a table.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        protected int GetRowCount(string table)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM {table}", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
        }
    }
}
