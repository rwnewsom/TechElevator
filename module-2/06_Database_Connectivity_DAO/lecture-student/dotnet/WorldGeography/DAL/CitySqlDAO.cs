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
        private const string SqlSelect = "SELECT id, name, countrycode, district, population FROM city WHERE countryCode = @countryCode;";

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

                    command.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Could not find city: "+ ex.Message);
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
                    command.Parameters.AddWithValue("@countrycode", countryCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        City city = new City();

                        city.CityId = Convert.ToInt32(reader["id"]);
                        city.Name = Convert.ToString(reader["name"]);
                        city.CountryCode = Convert.ToString(reader["countrycode"]);
                        city.District = Convert.ToString(reader["district"]);
                        city.Population = Convert.ToInt32(reader["population"]);

                        //my attempt

                        cities.Add(city);
                    }
                    
                }
                
            }
            
            catch(SqlException ex)
            {
                Console.WriteLine("error getting cities: " + ex.Message);
            }

            return cities;
        }
    }
}
