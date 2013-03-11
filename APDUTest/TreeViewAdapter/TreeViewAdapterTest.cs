using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParserLib;
using TreeViewColumnsProject;

namespace APDUTest.TreeViewAdapter
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TreeViewAdapterTest
    {


        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        [TestCategory("UI Converter")]
        public void TLV_Convert__1Level_Nominal()
        {
            TLV data = new TLV() { Tag = "AB", Length = 1, Value = "aa" };
            TreeNode res = DataConverter.fromTLV(data);
            Assert.AreEqual("AB", res.Name);

            Assert.IsInstanceOfType(res.Tag,typeof(string[]));
            string[] nodeContent = (string[])res.Tag;
            Assert.AreEqual("01", nodeContent[0]);
            Assert.AreEqual("aa", nodeContent[1]);
            
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        [TestCategory("UI Converter")]
        public void TLV_Convert__2Level_Nominal()
        {
            TLV parent= new TLV() { Tag = "AB", Length = 6, Value = "CC01A1CC01A2" };
            TLV child1 = new TLV() { Tag = "CC", Length = 1, Value = "A1" };
            TLV child2 = new TLV() { Tag = "CC", Length = 1, Value = "A2" };
            parent.addChild(child1);
            parent.addChild(child2);

            //verify parent
            TreeNode res = DataConverter.fromTLV(parent);
            assertTreeNodeAndTLV(parent, res);

            // verify children
            Assert.IsNotNull(res.Nodes);
            Assert.AreEqual(2, res.Nodes.Count);

            // first chidren
            assertTreeNodeAndTLV(child1,res.Nodes[0]);
            // second chidren
            assertTreeNodeAndTLV(child2, res.Nodes[1]);

        }

        private void assertTreeNodeAndTLV(TLV expected, TreeNode actual)
        {

            Assert.AreEqual(expected.Tag, actual.Name);
            string[] nodeContent3 = (string[])actual.Tag;

            Assert.IsInstanceOfType(actual.Tag, typeof(string[]));
            Assert.AreEqual(makeEven(expected.Length.ToString()),nodeContent3[0]);
            Assert.AreEqual(expected.Value, nodeContent3[1]);
        }


        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        [TestCategory("UI Converter")]
        public void TLV_Convert__3Level_Nominal()
        {


            TLV parent = new TLV() { Tag = "AB", Length = 5, Value = "CC03GC01A2" };
            TLV child = new TLV() { Tag = "CC", Length = 3, Value = "GC01A2" };
            TLV grandChild = new TLV() { Tag = "GC", Length = 1, Value = "A2" };
            parent.addChild(child);
            child.addChild(grandChild);

            //verify parent
            TreeNode res = DataConverter.fromTLV(parent);
            assertTreeNodeAndTLV(parent, res);

            // verify children
            Assert.IsNotNull(res.Nodes);
            Assert.AreEqual(1, res.Nodes.Count);
            assertTreeNodeAndTLV(child, res.Nodes[0]);
            
            // veriy grandchidren
            Assert.IsNotNull(res.Nodes[0].Nodes);
            Assert.AreEqual(1,res.Nodes[0].Nodes.Count);
            assertTreeNodeAndTLV(grandChild, res.Nodes[0].Nodes[0]);

        }

        public string makeEven(string val)
        {
            string result = val;
            if (val.Length % 2 != 0)
            {
                result= "0" + val;
            }
            return result;
        }
        
    }
}
