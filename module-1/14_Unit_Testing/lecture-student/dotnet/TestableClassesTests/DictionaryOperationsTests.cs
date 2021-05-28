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
            //arrange
            DictionaryOperations ops = new DictionaryOperations();
            string[] words = { "Testing", "is", "addictive" };

            //act
            Dictionary <string, int> result = ops.GetWordLengths(words);

            //assert - adding extra message about test failures
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Keys.Count, "Did not get the expected number of keys");
            Assert.IsTrue(result.ContainsKey("Testing"));
            Assert.AreEqual(7, result["Testing"]);
        }

    }
}
