using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAO : ILanguageDAO
    {
        private readonly string connectionString;

        /// <summary>
        /// Creates a sql based language dao.
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public LanguageSqlDAO(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public IList<Language> GetLanguages(string countryCode)
        {
            List<Language> languages = new List<Language>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT countrycode AS code, language, isofficial, percentage " +
                                 "FROM countrylanguage " +
                                 $"WHERE countrycode = @countryCode ";

                    string badSql = "SELECT countrycode AS code, language, isofficial, percentage " +
                                 "FROM countrylanguage " +
                                 "WHERE countrycode = '" + countryCode + "'"; // '; DELETE FROM countrylanguage; --

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@countrycode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Language language = new Language();

                        language.CountryCode = Convert.ToString(reader["code"]);
                        language.Name = Convert.ToString(reader["language"]);
                        language.IsOfficial = Convert.ToBoolean(reader["isofficial"]);
                        language.Percentage = Convert.ToInt32(reader["percentage"]);

                        languages.Add(language);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error retrieving languages.");
                Console.WriteLine(ex.Message);

                throw;
            }

            return languages;
        }


/* SQL Injection attack ideas ...
' OR 1=1; --
'; UPDATE country SET headofstate = 'Matt Eland'; --
'; DELETE FROM countrylanguage; --
*/

        public bool AddNewLanguage(Language newLanguage)
        {
            try
            {
                // Create a connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create the command
                    SqlCommand cmd = new SqlCommand("INSERT INTO countrylanguage VALUES (@countrycode, @language, @isofficial, @percentage);", conn);
                    cmd.Parameters.AddWithValue("@countrycode", newLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", newLanguage.Name);
                    cmd.Parameters.AddWithValue("@isofficial", newLanguage.IsOfficial);
                    cmd.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred saving the new language.");
                Console.WriteLine(ex.Message);

                throw;
            }

            return true;
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            try
            {
                // Create a connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create the command
                    SqlCommand cmd = new SqlCommand("DELETE FROM countrylanguage WHERE countrycode = @countrycode and language = @language", conn);
                    cmd.Parameters.AddWithValue("@countrycode", deadLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", deadLanguage.Name);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred saving the new language.");
                Console.WriteLine(ex.Message);

                throw;
            }

            return true;
        }
    }
}

