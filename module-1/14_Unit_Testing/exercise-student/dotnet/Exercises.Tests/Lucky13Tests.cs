using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, false)]
        [DataRow(new int[] { 0, 2, 4 }, true)]
        [DataRow(new int[] { 1, 2, 4 }, false)]
        public void ArrayWithOnesOrThreesShouldReturnFalse(int[] nums, bool expected)
        {
            //Arrange
            Lucky13 unLucky = new Lucky13();

            //Act

            bool result = unLucky.GetLucky(nums);

            //Assert
            Assert.AreEqual(expected, result);



        }
    }
}
