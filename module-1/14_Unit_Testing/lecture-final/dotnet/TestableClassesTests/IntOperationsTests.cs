using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class IntOperationsTests
    {
        [TestMethod]
        public void IsOdd_OddNumbersShouldReturnTrue()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.IsOdd(3);

            // Assert
            Assert.IsTrue(result); // If result is false, test fails
            Assert.AreEqual(true, result); // ditto
            // Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void IsOdd_ZeroShouldReturnFalse()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.IsOdd(0);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        [DataRow(4,false)]
        [DataRow(3, true)]
        [DataRow(-2, false)]
        [DataRow(-1, true)]
        public void IsOdd_NumberShouldReturnExpectedValue(int number, bool expected)
        {
            //Arrange
            IntOperations operations = new IntOperations();

            //Act
            bool result = operations.IsOdd(number);

            //assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AreNumbersDivisible_ThreeAndSixShouldBeDivisible()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.AreNumbersDivisible(3, 6);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void AreNumbersDivisible_SixAndTwoShouldNotBeDivisible()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.AreNumbersDivisible(6, 2);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AreNumbersDivisible_DivideByZeroShouldReturnFalse()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.AreNumbersDivisible(0, 42);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MultiplyAbsolute_MultiplyByZeroShouldBeZero()
        {
            // Arrange
            IntOperations operations = new IntOperations();

            // Act
            int result = operations.MultiplyAbsolute(50, 0);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
