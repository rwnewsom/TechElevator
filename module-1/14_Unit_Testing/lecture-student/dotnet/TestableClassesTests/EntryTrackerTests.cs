using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class EntryTrackerTests
    {
        [TestMethod]
        public void EntryTrackerShouldStartWithZeroPeople()
        {
            //Arrange
            EntryTracker tracker = new EntryTracker();

            //Act
            int numPeople = tracker.NumberOfPeople;

            //Assert
            Assert.AreEqual(0, numPeople);
        }

        [TestMethod]
        public void OpeningEntryDoorShouldIncreasePeopleCount()
        {
            // Arrange
            EntryTracker tracker = new EntryTracker();

            //Act
            tracker.EntryDoorOpened();

            //Assert

            Assert.AreEqual(1, tracker.NumberOfPeople);

        }


        [TestMethod]
        public void OpeningEntryDoorMultipleTimesShouldIncreasePeopleCount()
        {
            // Arrange
            EntryTracker tracker = new EntryTracker();
            tracker.EntryDoorOpened();
            tracker.EntryDoorOpened();
            //Act
            tracker.EntryDoorOpened();

            //Assert

            Assert.AreEqual(3, tracker.NumberOfPeople);

        }

        [TestMethod]
        public void OpeningEntryDoorandOpeningExitDoorShouldResultInZeroPeople()
        {
            // Arrange
            EntryTracker tracker = new EntryTracker();
            tracker.EntryDoorOpened();
            
            //Act
            tracker.ExitDoorOpened();

            //Assert

            Assert.AreEqual(0, tracker.NumberOfPeople);

        }

        [TestMethod]

        public void OpeningExitDorWhenZeroPeoplePresentShouldResultInZeroPeople()
        {
            //arrange
            EntryTracker tracker = new EntryTracker();

            //act

            tracker.ExitDoorOpened();

            //assert
            Assert.AreEqual(0, tracker.NumberOfPeople);

        }

    }
}
