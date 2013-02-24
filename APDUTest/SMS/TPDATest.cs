using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib.SMS;

namespace APDUTest.SMS
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TPDATest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestEvenTPDA()
        {
            TPDA SUT = new TPDA();
            SUT.parse("04821235");
            Assert.AreEqual(4, SUT.NumberOfNibble);
            Assert.AreEqual("82", SUT.TON_NPI);
            Assert.AreEqual("1235", SUT.Address);
            Assert.AreEqual("2153", SUT.RealAddress);
        }

        [TestMethod]
        public void TestOddTPDA()
        {
            TPDA SUT = new TPDA();
            SUT.parse("05821235F5");
            Assert.AreEqual(5, SUT.NumberOfNibble);
            Assert.AreEqual("82", SUT.TON_NPI);
            Assert.AreEqual("1235F5", SUT.Address);
            Assert.AreEqual("21535", SUT.RealAddress);
            
        }
    }
}
