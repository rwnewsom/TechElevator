using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void ChocolateTwoShouldReturnChoCho()
        {

            //Arrange
            FrontTimes trainGoes = new FrontTimes();

            //Act
            string sound = trainGoes.GenerateString("Chocolate", 2);

            //Assert
            Assert.AreEqual("ChoCho", sound);
        }

        [TestMethod]
        public void BoonThreeShouldReturnBooBooBoo()
        {
            //Arrange
            FrontTimes ghostSound = new FrontTimes();

            //Act
            string sound = ghostSound.GenerateString("Boon", 3);

            //Assert
            Assert.AreEqual("BooBooBoo", sound);
        }

        [TestMethod]
        public void AbraCadebraOneShouldReturnAbr() 
        {
            //Arrange
            FrontTimes magician = new FrontTimes();

            //Act
            string magicWords = magician.GenerateString("AbraCadebra", 1);

            //Assert
            Assert.AreEqual("Abr", magicWords);
        }
    }
}
