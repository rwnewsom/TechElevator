using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private readonly string connectionString;

        private const string SqlSelectAll = "SELECT code, name, continent, region, surfacearea, population, governmentform FROM country";
        private const string SqlSelectAllByContinent = "SELECT code, name, continent, region, surfacearea, population, governmentform FROM country WHERE continent = @continent";

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IEnumerable<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelectAll, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        countries.Add(GetCountryFromDataReader(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Problem getting countries: " + ex.Message);
            }

            return countries;
        }

        public IEnumerable<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelectAllByContinent, conn);
                    command.Parameters.AddWithValue("@continent", continent);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        countries.Add(GetCountryFromDataReader(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Problem getting countries: " + ex.Message);
            }

            return countries;
        }

        private Country GetCountryFromDataReader(SqlDataReader reader)
        {
            Country country = new Country();

            country.Code = Convert.ToString(reader["code"]);
            country.Name = Convert.ToString(reader["name"]);
            country.Continent = Convert.ToString(reader["continent"]);
            country.Region = Convert.ToString(reader["region"]);
            country.GovernmentForm = Convert.ToString(reader["governmentform"]);
            country.Population = Convert.ToInt32(reader["population"]);
            country.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);

            return country;
        }
    }
}
