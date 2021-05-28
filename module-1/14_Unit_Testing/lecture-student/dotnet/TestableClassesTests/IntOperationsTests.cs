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
            Assert.AreEqual(true, result); //ditto

        }
        [TestMethod]
        public void isOdd_ZeroShouldReturnFalse()
        {
            //ARRANGE
            IntOperations operations = new IntOperations();

            //ACT
            bool result = operations.IsOdd(0);
            //ASSERT

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AreNumbersDivisible_ThreeAndSixShouldBeDivisible()
        {
            // ARRANGE
            IntOperations operations = new IntOperations();

            // Act
            bool result = operations.AreNumbersDivisible(3, 6);

            // ASSERT
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void AreNumbersDivisible_SixAndThreeShouldNotBeDivisible()
        {
            // ARRANGE
            IntOperations operations = new IntOperations();

            // ACT

            bool result = operations.AreNumbersDivisible(6, 2);

            // ASSERT

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void AreNumbersDivisible_DivideByZeroShouldReturnFlase()
        {
            //Arrange
            IntOperations operations = new IntOperations();

            //Act

            bool result = operations.AreNumbersDivisible(0, 42);

            //ASSERT
            Assert.AreEqual(false, result);
        }

        [TestMethod]

        public void MultiplyAbsolute_MultiplyByZeroShouldBeZero()
        {
            // Arrange

            IntOperations operations = new IntOperations();

            //Act
            int result = operations.MultiplyAbsolute(50, 0);
            //Assert
            Assert.AreEqual(0, result);
        }

    }
}
