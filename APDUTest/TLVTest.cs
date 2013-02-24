using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib;

namespace APDUTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TLVTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_NoChild()
        {
            var testData = "8010112233445566778899AABBCCDDEEFF00";
            TLV expected = new TLV() { Tag = "80", Length = 16, Value = "112233445566778899AABBCCDDEEFF00" };
            TLV parent = TLV.parse(testData);
            Helper.compareTLV(expected, parent);
        }

        [TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_4Childs()
        {
            var testData = "D01B81030125008202818205008F0E0143535049524520476C6F62616C";
            TLV expected = new TLV() { Tag = "D0", Length = 27, Value = "81030125008202818205008F0E0143535049524520476C6F62616C" };
            TLV child1 = new TLV() { Tag = "81", Length = 3, Value = "012500" };
            TLV child2 = new TLV() { Tag = "82", Length = 2, Value = "8182" };
            TLV child3 = new TLV() { Tag = "05", Length = 0, Value = null };
            TLV child4 = new TLV() { Tag = "8F", Length = 14, Value = "0143535049524520476C6F62616C" };
            expected.addChild(child1);
            expected.addChild(child2);
            expected.addChild(child3);
            expected.addChild(child4);
            TLV result = TLV.parse(testData);

            Helper.compareTLV(expected, result);            

        }

        [TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_GrandChild()
        {
            var testData = "GG088106980484028899";
            TLV grandParent = new TLV() { Tag = "GG", Length = 8, Value = "8106980484028899" };
            
            TLV parent = new TLV() { Tag = "81", Length = 6, Value = "980484028899" };
            grandParent.addChild(parent);
            
            TLV child = new TLV() { Tag = "98", Length = 4, Value = "84028899" };
            parent.addChild(child);

            TLV grandChild = new TLV() { Tag = "84", Length = 2, Value = "8899" };
            child.addChild(grandChild);

            TLV result = TLV.parse(testData);

            Helper.compareTLV(grandParent, result);

        }
        [TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_2GrandChild()
        {
            var testData = "GG0C810A98088402889985020032";
            TLV grandParent = new TLV() { Tag = "GG", Length = 12, Value = "810A98088402889985020032" };

            TLV parent = new TLV() { Tag = "81", Length = 10, Value = "98088402889985020032" };
            grandParent.addChild( parent );

            TLV child = new TLV() { Tag = "98", Length = 8, Value = "8402889985020032" };
            parent.addChild(child);

            TLV grandChild1= new TLV() { Tag = "84", Length = 2, Value = "8899" };

            TLV grandChild2 = new TLV() { Tag = "85", Length = 2, Value = "0032" };
            child.addChild(grandChild1);
            child.addChild(grandChild2);

            TLV result = TLV.parse(testData);

            Helper.compareTLV(grandParent, result);

        }

        [TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_2Parent()
        {
            var testData = "GG1082048502332283088606004455668877";
            TLV grandParent = new TLV() { Tag = "GG", Length = 16, Value = "82048502332283088606004455668877" };

            TLV parent1 = new TLV() { Tag = "82", Length = 4, Value = "85023322" };
            TLV child1 = new TLV() { Tag = "85", Length = 2, Value = "3322" };
            parent1.addChild(child1);


            TLV parent2 = new TLV { Tag = "83", Length = 8, Value = "8606004455668877" };
            TLV child2 = new TLV() { Tag = "86", Length = 6, Value = "004455668877" };
            parent2.addChild( child2 );


            grandParent.addChild( parent1);
            grandParent.addChild(parent2);

            TLV result = TLV.parse(testData);

            Helper.compareTLV(grandParent, result);

        }

        [TestMethod]
        [TestCategory("TLV")]
        public void TLV_Normal_2Child()
        {

            var testData = "GG0A82088502332285023322";
            TLV grandParent = new TLV() { Tag = "GG", Length = 10, Value = "82088502332285023322" };

            TLV parent = new TLV() { Tag = "82", Length = 8, Value = "8502332285023322" };
            TLV child1 = new TLV() { Tag = "85", Length = 2, Value = "3322" };
            TLV child2 = new TLV() { Tag = "85", Length = 2, Value = "3322" };
            parent.addChild(child1);
            parent.addChild(child2);
        }

        
    }
}
