using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        public void TwoAndEightYieldsZero()
        {
            //arrange
            DateFashion zeroAndHero = new DateFashion();

            //act
            int result = zeroAndHero.GetATable(2, 8);

            //assert

            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ThreeAndTenYieldsTwo()
        {
            //arrange
            DateFashion ladyAndTramp = new DateFashion();

            //act
            int result = ladyAndTramp.GetATable(10, 3);

            //assert

            Assert.AreEqual(2, result);

        }


        [TestMethod]
        public void FiveAndFiveYieldsOne()
        {
            //arrange
            DateFashion normcoreCouple = new DateFashion();

            //act
            int result = normcoreCouple.GetATable(5, 5);

            //assert

            Assert.AreEqual(1, result);

        }



    }
}
