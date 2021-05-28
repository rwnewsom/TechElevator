using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        public void WeekdayPartyUnderFortySHouldFail()
        {
            //ARRANGE

            CigarParty weekdayFailParty = new CigarParty();

            //ACT

            bool outcome = weekdayFailParty.HaveParty(39, false);

            //ASSERT
            Assert.AreEqual(false, outcome);

        }


        [TestMethod]
        public void WeekdayPartyOverSixtySHouldFail()
        {
            //ARRANGE

            CigarParty weekdayFailExcessParty = new CigarParty();

            //ACT

            bool outcome = weekdayFailExcessParty.HaveParty(61, false);

            //ASSERT
            Assert.AreEqual(false, outcome);

        }

        [TestMethod]
        public void WeekendSuccessfulParty()
        {
            //ARRANGE

            CigarParty weekendSeventy = new CigarParty();

            //ACT

            bool outcome = weekendSeventy.HaveParty(70, true);

            //ASSERT
            Assert.AreEqual(true, outcome);

        }

    }

}
