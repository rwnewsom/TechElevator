using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(this.ConnectionString);
            int expectedResults = this.GetRowCount("country");

            // Act
            IList<Country> results = dao.GetCountries();

            // Assert
            Assert.IsTrue(results.Count > 0);
            Assert.AreEqual(expectedResults, results.Count);
            //Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        [DataRow("North America", 1)]
        [DataRow("South America", 0)]
        [DataRow("Asia", 0)]
        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedCount)
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(this.ConnectionString);

            // Act
            IList<Country> countries = dao.GetCountries(continent);

            // Assert
            Assert.AreEqual(expectedCount, countries.Count);
        }
    }
}
