using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void BaBaBlackSheepShouldHaveThreeKeys()
        {
            //Arrange
            WordCount counter = new WordCount();
            string[] sample = { "ba", "ba", "black", "sheep" };
            
            //Act
            Dictionary<string, int> result = counter.GetCount(sample);

            //Assert
            Assert.AreEqual(3, result.Keys.Count, "Did not get the expected number of keys");
        }

        [TestMethod]
        public void BaBaBlackSheepShouldHaveKeySheep()
        {
            //Arrange
            WordCount counter = new WordCount();
            string[] sample = { "ba", "ba", "black", "sheep" };

            //Act
            Dictionary<string, int> result = counter.GetCount(sample);

            //Assert
            Assert.IsTrue(result.ContainsKey("sheep"));
        }

        [TestMethod]
        public void BaBaBlackSheepShouldHaveTwoBas()
        {
            //Arrange
            WordCount counter = new WordCount();
            string[] sample = { "ba", "ba", "black", "sheep" };

            //Act
            Dictionary<string, int> result = counter.GetCount(sample);

            //Assert
            Assert.AreEqual(2, result["ba"]);
        }
    }
}
