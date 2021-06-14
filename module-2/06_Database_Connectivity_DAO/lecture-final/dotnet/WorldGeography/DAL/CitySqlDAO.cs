using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private readonly string connectionString;

        private const string SqlInsert = "INSERT INTO city (name, countrycode, district, population) VALUES (@name, @countrycode, @district, @population);";
        private const string SqlSelect = "SELECT id, name, countrycode, district, population FROM city WHERE countryCode = @countryCode; SELECT @@IDENTITY;";

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlInsert, conn);
                    command.Parameters.AddWithValue("@name", city.Name);
                    command.Parameters.AddWithValue("@countrycode", city.CountryCode);
                    command.Parameters.AddWithValue("@district", city.District);
                    command.Parameters.AddWithValue("@population", city.Population);

                    // Execute the query and get a single result. This will be the result of our "Select @@Identity" statement.
                    // @@Identity refers to the ID of the last row that we created with our query, so it will be our city's primary key.
                    int id = Convert.ToInt32(command.ExecuteScalar());

                    Console.WriteLine("Just created city " + id);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not add city: " + ex.Message);
            }
        }

        public IEnumerable<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> cities = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelect, conn);
                    command.Parameters.AddWithValue("@countryCode", countryCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        City city = new City();

                        city.CityId = Convert.ToInt32(reader["id"]);
                        city.Name = Convert.ToString(reader["name"]);
                        city.CountryCode = Convert.ToString(reader["countrycode"]);
                        city.District = Convert.ToString(reader["district"]);
                        city.Population = Convert.ToInt32(reader["population"]);

                        cities.Add(city);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Problem getting cities: " + ex.Message);
            }

            return cities;
        }
    }
}
