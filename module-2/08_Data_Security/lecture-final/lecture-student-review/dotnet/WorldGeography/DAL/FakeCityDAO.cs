using System;
using System.Collections.Generic;
using System.Text;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class FakeCityDAO : ICityDAO
    {
        private List<City> cities;

        public FakeCityDAO()
        {
            cities = new List<City>();
            cities.Add(new City
            {
                Name = "Columbus",
                District = "OH",
                Population = 15,
                CountryCode = "USA",
                CityId = 1
            });
        }

        public int AddCity(City city)
        {
            cities.Add(city);

            return cities.Count;
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> filteredCities = new List<City>();

            foreach (City city in cities)
            {
                if (city.CountryCode == countryCode)
                {
                    filteredCities.Add(city);
                }
            }

            return filteredCities;
        }
    }
}
