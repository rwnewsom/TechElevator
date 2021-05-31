using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [DataRow(new int[] { 0, 2, 4 }, new int[] { 4, 4, 4 })]
        [DataRow(new int[] { 8, 2, 7 }, new int[] { 8, 8, 8 })]
        [DataRow(new int[] { 2, 28, 9 }, new int[] { 9, 9, 9 })]
        [DataRow(new int[] { -8, 2, -7 }, new int[] { -7, -7, -7 })]
        public void ArrayWithOnesOrThreesShouldReturnFalse(int[] nums, int[] expected)
        {
            //Arrange
            MaxEnd3 samesies = new MaxEnd3();

            //Act

            int[] result = samesies.MakeArray(nums);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
            



        }
    }
}
