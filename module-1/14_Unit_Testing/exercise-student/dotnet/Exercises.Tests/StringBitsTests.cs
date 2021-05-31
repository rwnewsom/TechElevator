using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        [DataRow("Hello","Hlo")]
        [DataRow("Hi", "H")]
        [DataRow("Heeololeo","Hello")]

       
        public void SliceEveryOtherLetter(string one, string two)
        {
            //Arrange
            StringBits chopper = new StringBits();
            
            //act
            string result = chopper.GetBits(one);

            //Assert
            Assert.AreEqual(two,result);

        }
    }
}
