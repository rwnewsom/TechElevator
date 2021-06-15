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
            //throw new NotImplementedException();
            List<Language> languages = new List<Language>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    //build command
                    SqlCommand command = new SqlCommand(SqlSelectByCountry, conn);
                    command.Parameters.AddWithValue("@countrycode", countryCode);
                    //get a datareader to loop through rows
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //read moves to the next row in the data reader (incl first row)
                    {
                        //create a new entity to represent the row
                        Language language = new Language();

                        //set the value on the new thing
                        language.CountryCode = Convert.ToString(reader["countrycode"]);
                        language.Name = Convert.ToString(reader["language"]);
                        language.IsOfficial = Convert.ToBoolean(reader["isofficial"]);
                        language.Percentage = Convert.ToInt32(reader["percentage"]);
                        
                        //add it to our result
                        languages.Add(language);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("problem getting languages:" + ex.Message);
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
                    //create our insert command
                    SqlCommand command = new SqlCommand(SqlInsert, conn);
                    command.Parameters.AddWithValue("@countrycode", newLanguage.CountryCode);
                    command.Parameters.AddWithValue("@language", newLanguage.Name);
                    command.Parameters.AddWithValue("@isofficial", newLanguage.IsOfficial);
                    command.Parameters.AddWithValue("@percentage", newLanguage.Percentage);
                    //run our insert command
                    command.ExecuteNonQuery();

                    //rtn true if worked
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("could not insert language: " + ex.Message);
                return false;
            }
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            //throw new NotImplementedException();
            try
            {
                //establlish a connection to our database
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    //we need to explicitly open the connection
                    conn.Open();

                    //create a delete command
                    SqlCommand command = new SqlCommand(SqlDelete, conn);

                    //set parameters into the Delete Command
                    command.Parameters.AddWithValue("@countrycode", deadLanguage.CountryCode);
                    command.Parameters.AddWithValue("@countrycode", deadLanguage.Name);

                    //actually run the delete command
                    command.ExecuteNonQuery();

                    //assuming completion with no error
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
