using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        [DataRow("Hello","There","ellohere")]
        [DataRow("java", "code", "avaode")]
        [DataRow("shotl", "lava", "hotlava")]
        //[DataRow("shotl", "lava", "notlava")] *verifying that all DataRows were testing
        public void TwoStringsShouldConcatenateWithoutFirstChars(string wordsOne, string wordsTwo, string expected)
        {
            
            //Arrange
            NonStart pasting = new NonStart();

            //Act
            string result = pasting.GetPartialString(wordsOne, wordsTwo);

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
