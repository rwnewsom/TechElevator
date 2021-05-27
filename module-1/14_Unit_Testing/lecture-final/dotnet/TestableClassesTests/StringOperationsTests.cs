using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class StringOperationsTests
    {
        [TestMethod]
        public void MakeCapitalized_PurpleShouldProperlyCapitalize()
        {
            // Arrange
            StringOperations stringOps = new StringOperations();

            // Act
            string result = stringOps.MakeStandardCapitalizationString("purpLE");

            // Assert
            Assert.AreEqual("Purple", result);
        }

        [TestMethod]
        public void MakeCapitalized_EmptyStringShouldReturnEmptyString()
        {
            // Arrange
            StringOperations stringOps = new StringOperations();

            // Act
            string result = stringOps.MakeStandardCapitalizationString("");

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void MakeCapitalized_SingleCharacterStringShouldBeCapitalized()
        {
            // Arrange
            StringOperations stringOps = new StringOperations();

            // Act
            string result = stringOps.MakeStandardCapitalizationString("h");

            // Assert
            Assert.AreEqual("H", result);
        }

        [TestMethod]
        public void GetAddress_ColumbusShouldBeFormattedProperly()
        {
            // Arrange
            StringOperations stringOps = new StringOperations();

            // Act
            string result = stringOps.GetAddressString("Columbus", "OH");

            // Assert
            Assert.AreEqual("Columbus, OH", result);
        }

        [TestMethod]
        public void CalculateVowels_HelloShouldReturnTwo()
        {
            // Arrange
            StringOperations stringOps = new StringOperations();

            // Act
            int result = stringOps.CalculateNumberOfVowels("Hello");

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}
