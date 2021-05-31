using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        public void EmptyArrayShouldReturnFalse()
        {
            //Arrange
            SameFirstLast empty = new SameFirstLast();
            int[] nihl = new int[] { };
            //Act

            bool result = empty.IsItTheSame(nihl);

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OneTwoOneShouldReturnTrue()
        {
            //Arrange
            SameFirstLast samesies = new SameFirstLast();
            int[] oneTwoOne = { 1, 2, 1 };

            //Act
            bool result = samesies.IsItTheSame(oneTwoOne);

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OneTwoThreeShouldReturnFalse()
        {
            //Arrange
            SameFirstLast samesies = new SameFirstLast();
            int[] oneTwoThree = { 1, 2, 3 };

            //Act
            bool result = samesies.IsItTheSame(oneTwoThree);

            //Assert
            Assert.AreEqual(false, result);
        }


    }
}
