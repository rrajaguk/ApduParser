using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib.Util;

namespace APDUTest.UtilTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class BER_TLVTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestBERTLVConvertFromString()
        {
            string val = "80053362265544";
            int index = 2;
            int res = Conversion_BER_TLV.ConvertFromString(val, ref index);
            Assert.AreEqual(4, index);
            Assert.AreEqual(5, res);
        }
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestBERTLVConvertFromInt()
        {
            int val = 200;
            string tes = Conversion_BER_TLV.ConvertFromInt(val);
            Assert.AreEqual("81C8", tes);

            val = 14;
            tes = Conversion_BER_TLV.ConvertFromInt(val);
            Assert.AreEqual("0E", tes);

            val = 3399;
            tes = Conversion_BER_TLV.ConvertFromInt(val);
            Assert.AreEqual("820D47", tes);

            val = 128;
            tes = Conversion_BER_TLV.ConvertFromInt(val);
            Assert.AreEqual("8180", tes);
        }
    }
}
