using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        [TestMethod]
        public void AllIdentical_IdenticalArrayShouldReturnTrue()
        {
            // Arrange
            ArrayOperations arrays = new ArrayOperations();
            int[] numbers = { 3, 3, 3 };

            // Act
            bool result = arrays.AreAllNumbersIdentical(numbers);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GetLowest_ShouldReturnLowestNumber()
        {
            // Arrange
            ArrayOperations arrays = new ArrayOperations();
            int[] numbers = { 2, 135};

            // Act
            int result = arrays.GetLowestNumber(numbers);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Reverse_ShouldReverseArrays()
        {
            // Arrange
            ArrayOperations arrays = new ArrayOperations();
            int[] numbers = { 3, 7, -1, 5 };
            int[] expected = { 5, -1, 7, 3 };

            // Act
            int[] result = arrays.ReverseArray(numbers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Length, result.Length);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
