using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class DictionaryOperationsTests
    {
        [TestMethod]
        public void GetWordLengthsShouldReturnAccurateLengths()
        {
            // Arrange
            DictionaryOperations ops = new DictionaryOperations();
            string[] words = { "Testing", "is", "addictive" };

            // Act
            Dictionary<string, int> result = ops.GetWordLengths(words);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Keys.Count, "Did not get the expected number of keys");
            Assert.IsTrue(result.ContainsKey("Testing"));
            Assert.AreEqual(7, result["Testing"]);
        }
    }
}
