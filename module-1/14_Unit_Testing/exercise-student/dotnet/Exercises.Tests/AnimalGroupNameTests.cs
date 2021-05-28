using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercises;


namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        public void UnknownEntryShouldReturnUnknown()
        {
            //ARRANGE
            AnimalGroupName critter = new AnimalGroupName();

            //ACT

            string answer = critter.GetHerd("Yeti");

            //ASSERT
            Assert.AreEqual("unknown", answer);

        }

        [TestMethod]
        public void EmptyEntryShouldReturnUnknown()
        {
            //ARRANGE
            AnimalGroupName critter = new AnimalGroupName();

            //ACT

            string answer = critter.GetHerd("");

            //ASSERT
            Assert.AreEqual("unknown", answer);

        }

        [TestMethod]
        public void RhinoShouldReturnCrash()
        {
            //ARRANGE
            AnimalGroupName critter = new AnimalGroupName();

            //ACT

            string answer = critter.GetHerd("Rhino");

            //ASSERT
            Assert.AreEqual("Crash", answer);

        }

    }
}
