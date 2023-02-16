using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingTax
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void testSingle()
        {

            double result = taxBot.main.TaxSingle(175000);
            double expected = 67193.75;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testSeperate()
        {

            double result = taxBot.main.TaxSeperate(162000);
            double expected = 78842.5;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testBadInput()
        {

            bool result = taxBot.main.CheckInput("OOPS");
            bool expected = false;

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void testGoodInput()
        {

            bool result = taxBot.main.CheckInput("10.5");
            bool expected = true;

            Assert.AreEqual(result, expected);
        }

    }
}
