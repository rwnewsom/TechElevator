using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment;

namespace Assessment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FourNightStayRaidinMinibarAndTrashingPlaceShouldCost322Pt93()
        {
            // There should be a test class to test the new class.
            // the UnitTest1 class can server as a template for what's inside of
            // the test class

            //Arrange
            HotelReservation TestRes = new HotelReservation("Bob",4);

            //Act
            double actualCost = TestRes.CalculateActualTotal(true, true);

            //Assert

            Assert.AreEqual(322.93, actualCost);
        }

        [TestMethod]
        public void FourNightEstimateShouldBe239Pt96()
        {
            //Arrange
            HotelReservation TestRes = new HotelReservation("Rob", 4);

            //Act
            double output = TestRes.EstimatedTotal;

            //Assert

            Assert.AreEqual(239.96, output);
        }
    }
}
