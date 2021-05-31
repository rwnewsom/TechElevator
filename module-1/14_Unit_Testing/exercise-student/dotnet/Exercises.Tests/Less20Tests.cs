using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        [DataRow(18,true)]
        [DataRow(19, true)]
        [DataRow(20, false)]
        [DataRow(0, false)]
        public void OnlyTrueIfOneOrTwoLessThanMultipleOfTwenty(int number, bool expected)
        {
            //Arrange
            Less20 tryThree = new Less20();

            //Act

            bool result = tryThree.IsLessThanMultipleOf20(number);

            //Assert

            Assert.AreEqual(expected, result);

        }

    }
}
