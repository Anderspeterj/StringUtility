using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtility.Tests
{
    [TestClass()]
    public class TestStringUtility
    {
        [TestMethod()]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility classUnderTest = new StringUtility();
            int actualyResult = classUnderTest.CountOccourences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualyResult);
        }

        [TestMethod()]
        public void ShouldFindTwoSInMyMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtility classUnderTest = new StringUtility();
            int actualtResult = classUnderTest.CountOccourences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualtResult);

        }
        [TestMethod()]
        public void SearchShouldBeCaseSensitive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;
            StringUtility classUnderTest = new StringUtility();
            int actualtResult = classUnderTest.CountOccourences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualtResult);

        }

    }
}