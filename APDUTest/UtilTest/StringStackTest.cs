using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib;

namespace APDUTest.UtilTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class StringStackTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GetByteTest()
        {
            StringStack SS = new StringStack("112233445566");
            Assert.AreEqual("11", SS.getByte());
            Assert.AreEqual("22", SS.getByte());
            Assert.AreEqual("33", SS.getByte());
            Assert.AreEqual("44", SS.getByte());
            Assert.AreEqual("112233445566", SS.OriginalString);

        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void GetBytesTest()
        {
            StringStack SS = new StringStack("112233445566778899");
            Assert.AreEqual("1122", SS.getBytes(2));
            Assert.AreEqual("33", SS.getByte());
            Assert.AreEqual("44", SS.getByte());
            Assert.AreEqual("556677", SS.getBytes(3));
            Assert.AreEqual("112233445566778899", SS.OriginalString);

        }

        [TestMethod]
        public void getRemaining()
        {
            StringStack SS = new StringStack("11223344556677889900");
            Assert.AreEqual("1122", SS.getBytes(2));
            Assert.AreEqual("33", SS.getByte());
            Assert.AreEqual("44", SS.getByte());
            Assert.AreEqual("556677", SS.getBytes(3));
            Assert.AreEqual("889900", SS.getRemaining());
            
        }
        
    }
}
