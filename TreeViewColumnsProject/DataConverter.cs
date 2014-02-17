using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParserLib;
using ParserLib.Util;

namespace TreeViewColumnsProject
{
    public class DataConverter
    {
        public static TreeNode[] fromMultipleTLV(List<TLV> input)
        {

            List<TreeNode> result = new List<TreeNode>();

            foreach (var item in input)
            {
                result.Add(fromTLV(item));
            }

            return result.ToArray();
        }
        public static TreeNode fromTLV(TLV data)
        {
            if (data == null) {
                return null;
            }
            TreeNode result = new TreeNode(data.Tag);
            result.Name = data.Tag;
            // put the Length, Value, Description
            string[] content = { Conversion_BER_TLV.ConvertFromInt(data.Length), data.Value, data.Description };
            result.Tag = content;
            
            //traverse each child
            if (data.child!= null)
            {
                foreach(var child in data.child){
                    if (child != null)
                    {
                        result.Nodes.Add(DataConverter.fromTLV(child));
                    }
                }
            }
            return result;
        }
    }
}
