using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib;

namespace APDUTest
{
    [TestClass]
    public class APDUTest
    {

        APDU APDU;
        List<TLV> expected;

        [TestInitialize]
        public void InitTest()
        {
            APDU = new APDU();
            expected = new List<TLV>();
         
        }
        [TestMethod]
        public void TestAPDUNominal()
        {
            expected = Helper.CreateDefaultTLV();
            List<TLV> result =  APDU.Parse(Helper.DefaultTLV);
            Helper.compareListTLV(expected,result);
        }

        

        [TestMethod]

        [TestCategory("Obselete")]
        public void TestAPDUIncompleteValue()
        {
            expected = Helper.CreateDefaultTLV();
            List<TLV> result = APDU.Parse(Helper.DefaultTLV + "890311");
            Helper.compareListTLV(expected, result);
        }

        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUTagOnly()
        {
            List<TLV> result = APDU.Parse("80");
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUTagLengtOnly()
        {
            List<TLV> result = APDU.Parse("8000");
            Assert.AreEqual("80", result[0].Tag);
            Assert.AreEqual(0, result[0].Length);
            Assert.IsNull(result[0].Value);            
        }

        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUEmpty()
        {
            List<TLV> result = APDU.Parse("");
            Assert.AreEqual(0,result.Count);
        }

        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUHexLength()
        {
            List<TLV> result = APDU.Parse("8010112233445566778899AABBCCDDEEFF00");
            Helper.compareTLV(
                new TLV() { Length = 16, Tag = "80", Value = "112233445566778899AABBCCDDEEFF00" },
                    result[0]
                );
        }
        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUin1BERTLV()
        {
            //create a big TLV
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 200; i++)
            {
                sb.Append("BB");
            }
            TLV expected = new TLV()
            {
                Tag = "09",                 // 09
                Length = sb.Length / 2,     // 100
                Value = sb.ToString()       // BB repeated 100 times

            };

            List<TLV> result = APDU.Parse("0981C8" + sb.ToString());
            Helper.compareTLV(expected, result[0]);

            
        }
        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUinBERTLV()
        {
            //create a big TLV
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 256; i++)
            {
                sb.Append("BB");
            }
            TLV expected = new TLV()
            {
                Tag = "09",
                Length = sb.Length / 2,
                Value = sb.ToString()

            };

            List<TLV> result = APDU.Parse("09820100" + sb.ToString());
            Helper.compareTLV(expected, result[0]);
        }
        [TestMethod]
        [TestCategory("Obselete")]
        public void TestAPDUin2BERTLV()
        {
            //create a big TLV
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 65605; i++)
            {
                sb.Append("BB");
            }
            TLV expected = new TLV()
            {
                Tag = "09",
                Length = sb.Length / 2,
                Value = sb.ToString()

            };

            List<TLV> result = APDU.Parse("0983010045" + sb.ToString());
            Helper.compareTLV(expected, result[0]);
        }
    }

    public class Helper
    {
        public static string DefaultTLV = "8004112233440809112233445566778899";
        public static List<TLV> CreateDefaultTLV()
        {
            List<TLV> result = new List<TLV>();
            result.Add(new TLV() { Tag = "80", Length = 4, Value = "11223344" });
            result.Add(new TLV() { Tag = "08", Length = 9, Value = "112233445566778899" });

            return result;
        }
        public static void compareTLV(TLV expected, TLV result)
        {
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(expected.Tag, result.Tag);
            Assert.AreEqual(expected.Value, result.Value);

            // if has a child then traverse to make sure all the child is the same
            if (expected.child != null)
            {
                compareListTLV(expected.child, result.child);
            }
        }
        public static void compareListTLV(List<TLV> expected, List<TLV> result)
        {
            Assert.AreEqual(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                compareTLV(expected[i], result[i]);
            }
        }
    }
}
