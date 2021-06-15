using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAO : ILanguageDAO
    {
        private readonly string connectionString;

        private const string SqlSelectByCountry = "SELECT countrycode, language, isofficial, percentage FROM countrylanguage WHERE countrycode = @countrycode";
        private const string SqlInsert = "INSERT INTO countrylanguage (countrycode, language, isofficial, percentage) VALUES (@countrycode, @language, @isofficial, @percentage);";
        private const string SqlDelete = "DELETE FROM countrylanguage WHERE countrycode = @countrycode AND language = @language;";

        /// <summary>
        /// Creates a sql based language dao.
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public LanguageSqlDAO(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public IEnumerable<Language> GetLanguages(string countryCode)
        {
            List<Language> languages = new List<Language>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    // Build the select command
                    SqlCommand command = new SqlCommand(SqlSelectByCountry, conn);
                    command.Parameters.AddWithValue("@countrycode", countryCode);

                    // Get a DataReader to loop through the rows
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // Read moves to the next row in the data reader (including the first row)
                    {
                        // Create a new entity to represent the row
                        Language language = new Language();

                        // Set the values on the new thing
                        language.CountryCode = Convert.ToString(reader["countrycode"]);
                        language.Name = Convert.ToString(reader["language"]);
                        language.IsOfficial = Convert.ToBoolean(reader["isofficial"]);
                        language.Percentage = Convert.ToInt32(reader["percentage"]);

                        // Add it to our list of results
                        languages.Add(language);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Problem getting languages " + ex.Message);
            }

            return languages;
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    // Create our insert command
                    SqlCommand command = new SqlCommand(SqlInsert, conn);
                    command.Parameters.AddWithValue("@countrycode", newLanguage.CountryCode);
                    command.Parameters.AddWithValue("@language", newLanguage.Name);
                    command.Parameters.AddWithValue("@isofficial", newLanguage.IsOfficial);
                    command.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    // Run our insert command
                    command.ExecuteNonQuery();

                    // If we got here, it must have worked
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not insert language: " + ex.Message);
                return false;
            }
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            try
            {
                // Establish a connection to our database
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    // We need to explicitly open the connection
                    conn.Open();

                    // Create a Delete Command
                    SqlCommand command = new SqlCommand(SqlDelete, conn);

                    // Set parameters into the Delete Command
                    command.Parameters.AddWithValue("@countrycode", deadLanguage.CountryCode);
                    command.Parameters.AddWithValue("@language", deadLanguage.Name);

                    // Actually run the delete command
                    command.ExecuteNonQuery();

                    // Assume that the delete succeeded since we didn't error
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not remove language: " + ex.Message);

                return false;
            }
        }
    }
}
